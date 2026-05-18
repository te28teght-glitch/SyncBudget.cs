using System;
using System.Windows.Forms;
using SyncBudgetApp.Models;
using SyncBudgetApp.Data;
using Microsoft.EntityFrameworkCore;

namespace SyncBudgetApp
{
    public partial class AddEditTransactionForm : Form
    {
        private Transaction? _transaction;
        private AppDbContext? _context;
        
        public decimal Amount => numericUpDownAmount.Value;
        public string Type => comboBoxType.SelectedItem?.ToString() ?? "Expense";
        public string Category => comboBoxCategory.Text;
        public DateTime Date => dateTimePickerDate.Value;
        public string Note => textBoxNote.Text;
        
        public AddEditTransactionForm(Transaction? transaction = null)
        {
            InitializeComponent();
            
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var dbPath = Path.Combine(Application.UserAppDataPath, "budget.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
            _context = new AppDbContext(optionsBuilder.Options);
            
            if (transaction != null)
            {
                _transaction = transaction;
                LoadTransactionData();
                this.Text = "Редактирование транзакции";
                labelTitle.Text = "✏️ Редактирование транзакции";
            }
            else
            {
                this.Text = "Добавление транзакции";
                labelTitle.Text = "➕ Добавить транзакцию";
                dateTimePickerDate.Value = DateTime.Now;
                comboBoxType.SelectedIndex = 1;
            }
            
            LoadCategories();
        }
        
        private void LoadTransactionData()
        {
            if (_transaction == null) return;
            
            numericUpDownAmount.Value = _transaction.Amount;
            comboBoxType.SelectedItem = _transaction.Type;
            comboBoxCategory.Text = _transaction.Category;
            dateTimePickerDate.Value = _transaction.Date;
            textBoxNote.Text = _transaction.Note;
        }
        
        private void LoadCategories()
        {
            comboBoxCategory.Items.Clear();
            string? currentType = comboBoxType.SelectedItem?.ToString();
            
            if (string.IsNullOrEmpty(currentType))
                currentType = "Expense";
            
            if (currentType == "Income")
            {
                comboBoxCategory.Items.AddRange(new string[] { 
                    "Зарплата", "Фриланс", "Подарок", "Инвестиции", "Бонус", "Другое" 
                });
            }
            else
            {
                comboBoxCategory.Items.AddRange(new string[] { 
                    "Еда", "Транспорт", "Развлечения", "Коммунальные услуги", 
                    "Одежда", "Здоровье", "Образование", "Кафе", "Другое" 
                });
            }
            
            if (comboBoxCategory.Items.Count > 0 && string.IsNullOrEmpty(comboBoxCategory.Text))
                comboBoxCategory.SelectedIndex = 0;
        }
        
        private void ComboBoxType_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadCategories();
        }
        
        private void ButtonOK_Click(object? sender, EventArgs e)
        {
            if (numericUpDownAmount.Value <= 0)
            {
                MessageBox.Show("Сумма должна быть больше 0", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }
            
            if (string.IsNullOrWhiteSpace(comboBoxCategory.Text))
            {
                MessageBox.Show("Введите или выберите категорию", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _context?.Dispose();
            base.OnFormClosing(e);
        }
    }
}