namespace SyncBudgetApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        
        // Основные контейнеры
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelStats;
        
        // Кнопки меню
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonTransactions;
        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonSettings;
        
        // Кнопки действий
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        
        // Элементы управления
        private System.Windows.Forms.DateTimePicker dateTimePickerDay;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        
        // Статистика
        private System.Windows.Forms.Label labelStartAmount;
        private System.Windows.Forms.Label labelStartValue;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelIncomeValue;
        private System.Windows.Forms.Label labelExpense;
        private System.Windows.Forms.Label labelExpenseValue;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.Label labelRemainingValue;
        
        // Заголовок
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDate;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelStats = new System.Windows.Forms.Panel();
            
            // Кнопки меню
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonTransactions = new System.Windows.Forms.Button();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            
            // Кнопки действий
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            
            // Элементы
            this.dateTimePickerDay = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            
            // Статистика
            this.labelStartAmount = new System.Windows.Forms.Label();
            this.labelStartValue = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.labelIncomeValue = new System.Windows.Forms.Label();
            this.labelExpense = new System.Windows.Forms.Label();
            this.labelExpenseValue = new System.Windows.Forms.Label();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.labelRemainingValue = new System.Windows.Forms.Label();
            
            // Заголовки
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            
            this.panelSideMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.SuspendLayout();
            
            // ========== PANEL SIDE MENU (Левое меню) ==========
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(25, 30, 45);
            this.panelSideMenu.Controls.Add(this.buttonDashboard);
            this.panelSideMenu.Controls.Add(this.buttonTransactions);
            this.panelSideMenu.Controls.Add(this.buttonCategories);
            this.panelSideMenu.Controls.Add(this.buttonReports);
            this.panelSideMenu.Controls.Add(this.buttonSettings);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 800);
            this.panelSideMenu.TabIndex = 0;
            
            // Кнопка Dashboard
            this.buttonDashboard.BackColor = System.Drawing.Color.FromArgb(45, 50, 70);
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 80);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonDashboard.Size = new System.Drawing.Size(250, 60);
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = "📊  Главная";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            
            // Кнопка Transactions
            this.buttonTransactions.BackColor = System.Drawing.Color.FromArgb(35, 40, 60);
            this.buttonTransactions.FlatAppearance.BorderSize = 0;
            this.buttonTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonTransactions.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.buttonTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTransactions.Location = new System.Drawing.Point(0, 140);
            this.buttonTransactions.Name = "buttonTransactions";
            this.buttonTransactions.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonTransactions.Size = new System.Drawing.Size(250, 60);
            this.buttonTransactions.TabIndex = 1;
            this.buttonTransactions.Text = "💰  Транзакции";
            this.buttonTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTransactions.UseVisualStyleBackColor = false;
            
            // Кнопка Categories
            this.buttonCategories.BackColor = System.Drawing.Color.FromArgb(35, 40, 60);
            this.buttonCategories.FlatAppearance.BorderSize = 0;
            this.buttonCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategories.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonCategories.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.buttonCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategories.Location = new System.Drawing.Point(0, 200);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonCategories.Size = new System.Drawing.Size(250, 60);
            this.buttonCategories.TabIndex = 2;
            this.buttonCategories.Text = "📁  Категории";
            this.buttonCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategories.UseVisualStyleBackColor = false;
            
            // Кнопка Reports
            this.buttonReports.BackColor = System.Drawing.Color.FromArgb(35, 40, 60);
            this.buttonReports.FlatAppearance.BorderSize = 0;
            this.buttonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReports.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonReports.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.buttonReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReports.Location = new System.Drawing.Point(0, 260);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonReports.Size = new System.Drawing.Size(250, 60);
            this.buttonReports.TabIndex = 3;
            this.buttonReports.Text = "📈  Отчёты";
            this.buttonReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReports.UseVisualStyleBackColor = false;
            
            // Кнопка Settings
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(35, 40, 60);
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonSettings.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(0, 720);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonSettings.Size = new System.Drawing.Size(250, 60);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "⚙️  Настройки";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = false;
            
            // ========== PANEL MAIN (Основная область) ==========
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Controls.Add(this.panelStats);
            this.panelMain.Controls.Add(this.dateTimePickerDay);
            this.panelMain.Controls.Add(this.buttonAdd);
            this.panelMain.Controls.Add(this.buttonEdit);
            this.panelMain.Controls.Add(this.buttonDelete);
            this.panelMain.Controls.Add(this.dataGridViewTransactions);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1050, 800);
            this.panelMain.TabIndex = 1;
            
            // ========== PANEL HEADER (Шапка) ==========
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Controls.Add(this.labelDate);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1050, 80);
            this.panelHeader.TabIndex = 0;
            
            // Заголовок
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(45, 50, 70);
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(172, 46);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Финансы";
            
            // Дата
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.labelDate.Location = new System.Drawing.Point(900, 30);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(120, 28);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            
            // ========== PANEL STATS (Карточки статистики) ==========
            this.panelStats.BackColor = System.Drawing.Color.White;
            this.panelStats.Controls.Add(this.labelStartAmount);
            this.panelStats.Controls.Add(this.labelStartValue);
            this.panelStats.Controls.Add(this.labelIncome);
            this.panelStats.Controls.Add(this.labelIncomeValue);
            this.panelStats.Controls.Add(this.labelExpense);
            this.panelStats.Controls.Add(this.labelExpenseValue);
            this.panelStats.Controls.Add(this.labelRemaining);
            this.panelStats.Controls.Add(this.labelRemainingValue);
            this.panelStats.Location = new System.Drawing.Point(30, 100);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(980, 130);
            this.panelStats.TabIndex = 1;
            
            // Карточка "Было в начале"
            this.labelStartAmount.AutoSize = true;
            this.labelStartAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelStartAmount.ForeColor = System.Drawing.Color.FromArgb(100, 100, 120);
            this.labelStartAmount.Location = new System.Drawing.Point(40, 25);
            this.labelStartAmount.Name = "labelStartAmount";
            this.labelStartAmount.Size = new System.Drawing.Size(118, 25);
            this.labelStartAmount.TabIndex = 0;
            this.labelStartAmount.Text = "💰 Было в начале";
            
            this.labelStartValue.AutoSize = true;
            this.labelStartValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelStartValue.ForeColor = System.Drawing.Color.FromArgb(45, 50, 70);
            this.labelStartValue.Location = new System.Drawing.Point(35, 55);
            this.labelStartValue.Name = "labelStartValue";
            this.labelStartValue.Size = new System.Drawing.Size(88, 54);
            this.labelStartValue.TabIndex = 1;
            this.labelStartValue.Text = "0 ₽";
            
            // Карточка "Доходы"
            this.labelIncome.AutoSize = true;
            this.labelIncome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelIncome.ForeColor = System.Drawing.Color.FromArgb(100, 100, 120);
            this.labelIncome.Location = new System.Drawing.Point(280, 25);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(81, 25);
            this.labelIncome.TabIndex = 2;
            this.labelIncome.Text = "📈 Доходы";
            
            this.labelIncomeValue.AutoSize = true;
            this.labelIncomeValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelIncomeValue.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.labelIncomeValue.Location = new System.Drawing.Point(275, 55);
            this.labelIncomeValue.Name = "labelIncomeValue";
            this.labelIncomeValue.Size = new System.Drawing.Size(88, 54);
            this.labelIncomeValue.TabIndex = 3;
            this.labelIncomeValue.Text = "0 ₽";
            
            // Карточка "Расходы"
            this.labelExpense.AutoSize = true;
            this.labelExpense.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelExpense.ForeColor = System.Drawing.Color.FromArgb(100, 100, 120);
            this.labelExpense.Location = new System.Drawing.Point(530, 25);
            this.labelExpense.Name = "labelExpense";
            this.labelExpense.Size = new System.Drawing.Size(93, 25);
            this.labelExpense.TabIndex = 4;
            this.labelExpense.Text = "📉 Расходы";
            
            this.labelExpenseValue.AutoSize = true;
            this.labelExpenseValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelExpenseValue.ForeColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.labelExpenseValue.Location = new System.Drawing.Point(525, 55);
            this.labelExpenseValue.Name = "labelExpenseValue";
            this.labelExpenseValue.Size = new System.Drawing.Size(88, 54);
            this.labelExpenseValue.TabIndex = 5;
            this.labelExpenseValue.Text = "0 ₽";
            
            // Карточка "Осталось"
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelRemaining.ForeColor = System.Drawing.Color.FromArgb(100, 100, 120);
            this.labelRemaining.Location = new System.Drawing.Point(790, 25);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(98, 25);
            this.labelRemaining.TabIndex = 6;
            this.labelRemaining.Text = "💎 Осталось";
            
            this.labelRemainingValue.AutoSize = true;
            this.labelRemainingValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelRemainingValue.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.labelRemainingValue.Location = new System.Drawing.Point(785, 55);
            this.labelRemainingValue.Name = "labelRemainingValue";
            this.labelRemainingValue.Size = new System.Drawing.Size(88, 54);
            this.labelRemainingValue.TabIndex = 7;
            this.labelRemainingValue.Text = "0 ₽";
            
            // ========== ВЫБОР ДАТЫ ==========
            this.dateTimePickerDay.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateTimePickerDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDay.Location = new System.Drawing.Point(30, 250);
            this.dateTimePickerDay.Name = "dateTimePickerDay";
            this.dateTimePickerDay.Size = new System.Drawing.Size(180, 32);
            this.dateTimePickerDay.TabIndex = 2;
            this.dateTimePickerDay.ValueChanged += new System.EventHandler(this.dateTimePickerDay_ValueChanged);
            
            // ========== КНОПКИ ДЕЙСТВИЙ ==========
            // Кнопка Добавить
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(230, 250);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(140, 45);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "➕ Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            
            // Кнопка Редактировать
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(380, 250);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(140, 45);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "✏️ Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            
            // Кнопка Удалить
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(530, 250);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(140, 45);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "🗑️ Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            
            // ========== DATA GRID VIEW ==========
            this.dataGridViewTransactions.AllowUserToAddRows = false;
            this.dataGridViewTransactions.AllowUserToDeleteRows = false;
            this.dataGridViewTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dataGridViewTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTransactions.ColumnHeadersHeight = 40;
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTransactions.GridColor = System.Drawing.Color.FromArgb(230, 230, 235);
            this.dataGridViewTransactions.Location = new System.Drawing.Point(30, 310);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.ReadOnly = true;
            this.dataGridViewTransactions.RowHeadersVisible = false;
            this.dataGridViewTransactions.RowTemplate.Height = 40;
            this.dataGridViewTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(980, 460);
            this.dataGridViewTransactions.TabIndex = 6;
            
            // Стиль DataGridView
            this.dataGridViewTransactions.EnableHeadersVisualStyles = false;
            this.dataGridViewTransactions.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.dataGridViewTransactions.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(45, 50, 70);
            this.dataGridViewTransactions.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTransactions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTransactions.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridViewTransactions.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(45, 50, 70);
            this.dataGridViewTransactions.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.dataGridViewTransactions.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(45, 50, 70);
            this.dataGridViewTransactions.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 248, 252);
            
            // ========== ФОРМА ==========
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "💰 SyncBudget - Умный учёт финансов";
            this.panelSideMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.ResumeLayout(false);
        }
    }
}