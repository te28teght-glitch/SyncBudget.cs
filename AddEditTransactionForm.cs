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
            
            // Инициализация контекста
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var dbPath = Path.Combine(Application.UserAppDataPath, "budget.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
            _context = new AppDbContext(optionsBuilder.Options);
            
            if (transaction != null)
            {
                _transaction = transaction;
                LoadTransactionData();
                this.Text = "Редактирование транзакции";
            }
            else
            {
                this.Text = "Добавление транзакции";
                dateTimePickerDate.Value = DateTime.Now;
                comboBoxType.SelectedIndex = 1; // Expense по умолчанию
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
            
            // Добавляем категории по умолчанию
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
        
        private void InitializeComponent()
        {
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            
            // numericUpDownAmount
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Location = new System.Drawing.Point(130, 30);
            this.numericUpDownAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(220, 27);
            this.numericUpDownAmount.TabIndex = 0;
            this.numericUpDownAmount.ThousandsSeparator = true;
            
            // comboBoxType
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Items.AddRange(new object[] { "Income", "Expense" });
            this.comboBoxType.Location = new System.Drawing.Point(130, 70);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(220, 28);
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.SelectedIndexChanged += ComboBoxType_SelectedIndexChanged;
            
            // comboBoxCategory
            this.comboBoxCategory.Location = new System.Drawing.Point(130, 110);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(220, 28);
            this.comboBoxCategory.TabIndex = 2;
            
            // dateTimePickerDate
            this.dateTimePickerDate.Location = new System.Drawing.Point(130, 150);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(220, 27);
            this.dateTimePickerDate.TabIndex = 3;
            
            // textBoxNote
            this.textBoxNote.Location = new System.Drawing.Point(130, 190);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(220, 80);
            this.textBoxNote.TabIndex = 4;
            
            // Labels
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сумма:";
            
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тип:";
            
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Категория:";
            
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата:";
            
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Примечание:";
            
            // buttonOK
            this.buttonOK.Location = new System.Drawing.Point(130, 290);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 40);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += ButtonOK_Click;
            this.buttonOK.DialogResult = DialogResult.OK;
            
            // buttonCancel
            this.buttonCancel.Location = new System.Drawing.Point(250, 290);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 40);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            
            // AddEditTransactionForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 360);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.numericUpDownAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление транзакции";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}