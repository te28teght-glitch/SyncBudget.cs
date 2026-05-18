using Microsoft.EntityFrameworkCore;
using SyncBudgetApp.Data;
using SyncBudgetApp.Models;

namespace SyncBudgetApp;

public partial class Form1 : Form
{
    private AppDbContext _dbContext;

    public Form1()
    {
        InitializeComponent();
        
        // Подключение обработчиков событий
        this.buttonAdd.Click += new EventHandler(buttonAdd_Click);
        this.buttonEdit.Click += new EventHandler(buttonEdit_Click);
        this.buttonDelete.Click += new EventHandler(buttonDelete_Click);
        this.buttonFilter.Click += new EventHandler(buttonFilter_Click);
        
        // Инициализация базы данных
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        var dbPath = Path.Combine(Application.UserAppDataPath, "budget.db");
        optionsBuilder.UseSqlite($"Data Source={dbPath}");
        _dbContext = new AppDbContext(optionsBuilder.Options);
        
        // Установка дат
        dateTimePickerFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        dateTimePickerTo.Value = DateTime.Now;
        
        LoadTransactions();
    }

    private void LoadTransactions()
    {
        var transactions = _dbContext.Transactions
            .OrderByDescending(t => t.Date)
            .ToList();
        
        dataGridViewTransactions.DataSource = null;
        dataGridViewTransactions.DataSource = transactions;
        ConfigureDataGridViewColumns();
        UpdateStatistics();
    }

    private void LoadFilteredTransactions(DateTime from, DateTime to)
    {
        var transactions = _dbContext.Transactions
            .Where(t => t.Date >= from && t.Date <= to)
            .OrderByDescending(t => t.Date)
            .ToList();
        
        dataGridViewTransactions.DataSource = null;
        dataGridViewTransactions.DataSource = transactions;
        ConfigureDataGridViewColumns();
        UpdateStatistics();
    }

    private void ConfigureDataGridViewColumns()
    {
        if (dataGridViewTransactions.Columns.Count == 0) return;
        if (dataGridViewTransactions.DataSource == null) return;
        
        try
        {
            // Скрываем колонку Id
            if (dataGridViewTransactions.Columns.Contains("Id") && dataGridViewTransactions.Columns["Id"] != null)
            {
                dataGridViewTransactions.Columns["Id"].Visible = false;
            }
            
            // Настройка колонки Amount
            if (dataGridViewTransactions.Columns.Contains("Amount") && dataGridViewTransactions.Columns["Amount"] != null)
            {
                var amountColumn = dataGridViewTransactions.Columns["Amount"];
                amountColumn.HeaderText = "Сумма";
                amountColumn.DefaultCellStyle.Format = "N2";
                amountColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            
            // Настройка колонки Type
            if (dataGridViewTransactions.Columns.Contains("Type") && dataGridViewTransactions.Columns["Type"] != null)
            {
                dataGridViewTransactions.Columns["Type"].HeaderText = "Тип";
            }
            
            // Настройка колонки Category
            if (dataGridViewTransactions.Columns.Contains("Category") && dataGridViewTransactions.Columns["Category"] != null)
            {
                dataGridViewTransactions.Columns["Category"].HeaderText = "Категория";
            }
            
            // Настройка колонки Date
            if (dataGridViewTransactions.Columns.Contains("Date") && dataGridViewTransactions.Columns["Date"] != null)
            {
                var dateColumn = dataGridViewTransactions.Columns["Date"];
                dateColumn.HeaderText = "Дата";
                dateColumn.DefaultCellStyle.Format = "dd.MM.yyyy";
            }
            
            // Настройка колонки Note
            if (dataGridViewTransactions.Columns.Contains("Note") && dataGridViewTransactions.Columns["Note"] != null)
            {
                dataGridViewTransactions.Columns["Note"].HeaderText = "Примечание";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при настройке колонок: {ex.Message}");
        }
    }

    private void UpdateStatistics()
    {
        var fromDate = dateTimePickerFrom.Value.Date;
        var toDate = dateTimePickerTo.Value.Date;
        
        var filteredTransactions = _dbContext.Transactions
            .Where(t => t.Date >= fromDate && t.Date <= toDate)
            .ToList();
        
        decimal totalIncome = filteredTransactions.Where(t => t.Type == "Income").Sum(t => t.Amount);
        decimal totalExpense = filteredTransactions.Where(t => t.Type == "Expense").Sum(t => t.Amount);
        decimal balance = totalIncome - totalExpense;
        
        labelTotalIncome.Text = $"💰 Доходы: {totalIncome:F2} ₽";
        labelTotalExpense.Text = $"💸 Расходы: {totalExpense:F2} ₽";
        labelBalance.Text = $"📊 Баланс: {balance:F2} ₽";
        
        labelBalance.ForeColor = balance >= 0 ? Color.Green : Color.Red;
    }

    private void buttonFilter_Click(object sender, EventArgs e)
    {
        LoadFilteredTransactions(dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);
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
                
                RefreshData();
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
                
                RefreshData();
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
            RefreshData();
        }
    }

    private void RefreshData()
    {
        LoadFilteredTransactions(dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        _dbContext?.Dispose();
        base.OnFormClosing(e);
    }
}