namespace SyncBudgetApp
{
    partial class AddEditTransactionForm
    {
        private System.ComponentModel.IContainer components = null;
        
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.labelAmount = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelNote = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            
            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(500, 80);
            this.panelHeader.TabIndex = 0;
            
            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(30, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(280, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "➕ Добавить транзакцию";
            
            // panelContent
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.labelAmount);
            this.panelContent.Controls.Add(this.numericUpDownAmount);
            this.panelContent.Controls.Add(this.labelType);
            this.panelContent.Controls.Add(this.comboBoxType);
            this.panelContent.Controls.Add(this.labelCategory);
            this.panelContent.Controls.Add(this.comboBoxCategory);
            this.panelContent.Controls.Add(this.labelDate);
            this.panelContent.Controls.Add(this.dateTimePickerDate);
            this.panelContent.Controls.Add(this.labelNote);
            this.panelContent.Controls.Add(this.textBoxNote);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 80);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(500, 370);
            this.panelContent.TabIndex = 1;
            
            // labelAmount
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelAmount.ForeColor = System.Drawing.Color.FromArgb(45, 50, 70);
            this.labelAmount.Location = new System.Drawing.Point(30, 30);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(78, 25);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "💰 Сумма:";
            
            // numericUpDownAmount
            this.numericUpDownAmount.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.numericUpDownAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numericUpDownAmount.Location = new System.Drawing.Point(140, 25);
            this.numericUpDownAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(320, 34);
            this.numericUpDownAmount.TabIndex = 1;
            this.numericUpDownAmount.ThousandsSeparator = true;
            
            // labelType
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelType.ForeColor = System.Drawing.Color.FromArgb(45, 50, 70);
            this.labelType.Location = new System.Drawing.Point(30, 90);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(50, 25);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "📊 Тип:";
            
            // comboBoxType
            this.comboBoxType.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxType.Items.AddRange(new object[] { "Income", "Expense" });
            this.comboBoxType.Location = new System.Drawing.Point(140, 85);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(320, 36);
            this.comboBoxType.TabIndex = 3;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            
            // labelCategory
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(45, 50, 70);
            this.labelCategory.Location = new System.Drawing.Point(30, 150);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(99, 25);
            this.labelCategory.TabIndex = 4;
            this.labelCategory.Text = "📁 Категория:";
            
            // comboBoxCategory
            this.comboBoxCategory.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.comboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxCategory.Location = new System.Drawing.Point(140, 145);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(320, 36);
            this.comboBoxCategory.TabIndex = 5;
            
            // labelDate
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(45, 50, 70);
            this.labelDate.Location = new System.Drawing.Point(30, 210);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(66, 25);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "📅 Дата:";
            
            // dateTimePickerDate
            this.dateTimePickerDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(140, 205);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(320, 34);
            this.dateTimePickerDate.TabIndex = 7;
            
            // labelNote
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelNote.ForeColor = System.Drawing.Color.FromArgb(45, 50, 70);
            this.labelNote.Location = new System.Drawing.Point(30, 270);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(79, 25);
            this.labelNote.TabIndex = 8;
            this.labelNote.Text = "📝 Заметка:";
            
            // textBoxNote
            this.textBoxNote.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.textBoxNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNote.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxNote.Location = new System.Drawing.Point(140, 265);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(320, 80);
            this.textBoxNote.TabIndex = 9;
            
            // panelButtons
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.panelButtons.Controls.Add(this.buttonOK);
            this.panelButtons.Controls.Add(this.buttonCancel);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 450);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(500, 70);
            this.panelButtons.TabIndex = 2;
            
            // buttonOK
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(140, 15);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(150, 45);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "✅ Сохранить";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            
            // buttonCancel
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(158, 158, 158);
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(310, 15);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 45);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "❌ Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            
            // AddEditTransactionForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 520);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление транзакции";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        
        // Объявление полей формы (только здесь!)
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}