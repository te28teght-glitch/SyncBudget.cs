using Microsoft.EntityFrameworkCore;
using SyncBudgetApp.Data;
using SyncBudgetApp.Models;

namespace SyncBudgetApp;

public partial class Form1 : Form
{
    private AppDbContext _dbContext;
    private decimal startBalance = 0;

    public Form1()
    {
        InitializeComponent();
        
        // Подключение обработчиков событий
        this.buttonAdd.Click += new EventHandler(buttonAdd_Click);
        this.buttonEdit.Click += new EventHandler(buttonEdit_Click);
        this.buttonDelete.Click += new EventHandler(buttonDelete_Click);
        
        // Инициализация базы данных
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        var dbPath = Path.Combine(Application.UserAppDataPath, "budget.db");
        optionsBuilder.UseSqlite($"Data Source={dbPath}");
        _dbContext = new AppDbContext(optionsBuilder.Options);
        
        // Установка сегодняшней даты
        dateTimePickerDay.Value = DateTime.Now;
        
        // Запрос начальной суммы
        AskForStartBalance();
        
        LoadDayTransactions();
    }

    private void AskForStartBalance()
    {
        using (var dialog = new Form())
        {
            dialog.Text = "Начальный баланс";
            dialog.Size = new System.Drawing.Size(400, 200);
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;
            dialog.BackColor = System.Drawing.Color.FromArgb(30, 30, 35);
            
            var label = new Label()
            {
                Text = "💰 Введите сумму, которая была у вас в начале дня:",
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(340, 40),
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.Transparent
            };
            
            var numericUpDown = new NumericUpDown()
            {
                Location = new System.Drawing.Point(20, 70),
                Size = new System.Drawing.Size(340, 30),
                DecimalPlaces = 2,
                ThousandsSeparator = true,
                Maximum = 10000000,
                BackColor = System.Drawing.Color.FromArgb(60, 60, 65),
                ForeColor = System.Drawing.Color.White
            };
            
            var okButton = new Button()
            {
                Text = "OK",
                Location = new System.Drawing.Point(140, 110),
                Size = new System.Drawing.Size(100, 35),
                BackColor = System.Drawing.Color.FromArgb(50, 150, 50),
                FlatStyle = FlatStyle.Flat,
                ForeColor = System.Drawing.Color.White
            };
            
            okButton.Click += (s, e) => 
            {
                startBalance = numericUpDown.Value;
                dialog.DialogResult = DialogResult.OK;
                dialog.Close();
            };
            
            dialog.Controls.Add(label);
            dialog.Controls.Add(numericUpDown);
            dialog.Controls.Add(okButton);
            
            dialog.ShowDialog();
        }
    }

    private void LoadDayTransactions()
    {
        var selectedDate = dateTimePickerDay.Value.Date;
        
        var transactions = _dbContext.Transactions
            .Where(t => t.Date.Date == selectedDate)
            .OrderByDescending(t => t.Id)
            .ToList();
        
        dataGridViewTransactions.DataSource = null;
        dataGridViewTransactions.DataSource = transactions;
        ConfigureDataGridViewColumns();
        UpdateStatistics(selectedDate);
    }

    private void ConfigureDataGridViewColumns()
    {
        if (dataGridViewTransactions.Columns.Count == 0) return;
        
        try
        {
            if (dataGridViewTransactions.Columns.Contains("Id") && dataGridViewTransactions.Columns["Id"] != null)
                dataGridViewTransactions.Columns["Id"].Visible = false;
            
            if (dataGridViewTransactions.Columns.Contains("Amount") && dataGridViewTransactions.Columns["Amount"] != null)
            {
                var amountColumn = dataGridViewTransactions.Columns["Amount"];
                amountColumn.HeaderText = "Сумма";
                amountColumn.DefaultCellStyle.Format = "N2";
                amountColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                amountColumn.Width = 120;
            }
            
            if (dataGridViewTransactions.Columns.Contains("Type") && dataGridViewTransactions.Columns["Type"] != null)
            {
                var typeColumn = dataGridViewTransactions.Columns["Type"];
                typeColumn.HeaderText = "Тип";
                typeColumn.Width = 100;
            }
            
            if (dataGridViewTransactions.Columns.Contains("Category") && dataGridViewTransactions.Columns["Category"] != null)
            {
                dataGridViewTransactions.Columns["Category"].HeaderText = "Категория";
                dataGridViewTransactions.Columns["Category"].Width = 150;
            }
            
            if (dataGridViewTransactions.Columns.Contains("Date") && dataGridViewTransactions.Columns["Date"] != null)
            {
                var dateColumn = dataGridViewTransactions.Columns["Date"];
                dateColumn.HeaderText = "Время";
                dateColumn.DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                dateColumn.Width = 150;
            }
            
            if (dataGridViewTransactions.Columns.Contains("Note") && dataGridViewTransactions.Columns["Note"] != null)
            {
                dataGridViewTransactions.Columns["Note"].HeaderText = "Примечание";
                dataGridViewTransactions.Columns["Note"].Width = 300;
            }
            
            // Настройка цвета строк в зависимости от типа
            dataGridViewTransactions.RowPrePaint += DataGridViewTransactions_RowPrePaint;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
    
    private void DataGridViewTransactions_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
        var row = dataGridViewTransactions.Rows[e.RowIndex];
        if (row.DataBoundItem is Transaction transaction)
        {
            if (transaction.Type == "Income")
            {
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
            }
            else
            {
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(244, 67, 54);
            }
        }
    }

    private void UpdateStatistics(DateTime date)
    {
        var dayTransactions = _dbContext.Transactions
            .Where(t => t.Date.Date == date)
            .ToList();
        
        decimal totalIncome = dayTransactions.Where(t => t.Type == "Income").Sum(t => t.Amount);
        decimal totalExpense = dayTransactions.Where(t => t.Type == "Expense").Sum(t => t.Amount);
        decimal remaining = startBalance + totalIncome - totalExpense;
        
        labelStartValue.Text = $"{startBalance:N0} ₽";
        labelIncomeValue.Text = $"{totalIncome:N0} ₽";
        labelExpenseValue.Text = $"{totalExpense:N0} ₽";
        labelRemainingValue.Text = $"{remaining:N0} ₽";
        
        // Обновляем дату в шапке
        labelDate.Text = date.ToString("dd MMMM yyyy");
        
        // Цвет остатка
        if (remaining >= 0)
            labelRemainingValue.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
        else
            labelRemainingValue.ForeColor = System.Drawing.Color.FromArgb(244, 67, 54);
    }

    private void dateTimePickerDay_ValueChanged(object sender, EventArgs e)
    {
        LoadDayTransactions();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        using (var addForm = new AddEditTransactionForm())
        {
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var transaction = new Transaction
                {
                    Amount = addForm.Amount,
                    Type = addForm.Type,
                    Category = addForm.Category,
                    Date = addForm.Date,
                    Note = addForm.Note
                };
                
                _dbContext.Transactions.Add(transaction);
                _dbContext.SaveChanges();
                
                LoadDayTransactions();
            }
        }
    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
        if (dataGridViewTransactions.CurrentRow == null)
        {
            MessageBox.Show("Выберите транзакцию для редактирования", "Информация", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        
        var selectedTransaction = (Transaction)dataGridViewTransactions.CurrentRow.DataBoundItem;
        
        using (var editForm = new AddEditTransactionForm(selectedTransaction))
        {
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                selectedTransaction.Amount = editForm.Amount;
                selectedTransaction.Type = editForm.Type;
                selectedTransaction.Category = editForm.Category;
                selectedTransaction.Date = editForm.Date;
                selectedTransaction.Note = editForm.Note;
                
                _dbContext.Transactions.Update(selectedTransaction);
                _dbContext.SaveChanges();
                
                LoadDayTransactions();
            }
        }
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        if (dataGridViewTransactions.CurrentRow == null)
        {
            MessageBox.Show("Выберите транзакцию для удаления", "Информация", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        
        var selectedTransaction = (Transaction)dataGridViewTransactions.CurrentRow.DataBoundItem;
        
        var result = MessageBox.Show($"Удалить транзакцию на сумму {selectedTransaction.Amount:F2} ₽?",
            "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
        if (result == DialogResult.Yes)
        {
            _dbContext.Transactions.Remove(selectedTransaction);
            _dbContext.SaveChanges();
            LoadDayTransactions();
        }
    }
    
    private void buttonDashboard_Click(object sender, EventArgs e)
    {
        LoadDayTransactions();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        _dbContext?.Dispose();
        base.OnFormClosing(e);
    }
}