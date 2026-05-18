namespace SyncBudgetApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.Label labelTotalIncome;
        private System.Windows.Forms.Label labelTotalExpense;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        
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
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.labelTotalExpense = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.SuspendLayout();
            
            // dateTimePickerFrom
            this.dateTimePickerFrom.Location = new System.Drawing.Point(12, 12);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(120, 27);
            this.dateTimePickerFrom.TabIndex = 0;
            
            // dateTimePickerTo
            this.dateTimePickerTo.Location = new System.Drawing.Point(138, 12);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(120, 27);
            this.dateTimePickerTo.TabIndex = 1;
            
            // buttonFilter
            this.buttonFilter.Location = new System.Drawing.Point(264, 12);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(94, 29);
            this.buttonFilter.TabIndex = 2;
            this.buttonFilter.Text = "Фильтр";
            this.buttonFilter.UseVisualStyleBackColor = true;
            
            // labelTotalIncome
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalIncome.Location = new System.Drawing.Point(12, 55);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(82, 23);
            this.labelTotalIncome.TabIndex = 3;
            this.labelTotalIncome.Text = "💰 Доходы: 0";
            
            // labelTotalExpense
            this.labelTotalExpense.AutoSize = true;
            this.labelTotalExpense.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalExpense.Location = new System.Drawing.Point(12, 85);
            this.labelTotalExpense.Name = "labelTotalExpense";
            this.labelTotalExpense.Size = new System.Drawing.Size(85, 23);
            this.labelTotalExpense.TabIndex = 4;
            this.labelTotalExpense.Text = "💸 Расходы: 0";
            
            // labelBalance
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBalance.Location = new System.Drawing.Point(12, 118);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(73, 28);
            this.labelBalance.TabIndex = 5;
            this.labelBalance.Text = "📊 Баланс: 0";
            
            // dataGridViewTransactions
            this.dataGridViewTransactions.AllowUserToAddRows = false;
            this.dataGridViewTransactions.AllowUserToDeleteRows = false;
            this.dataGridViewTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(12, 155);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.ReadOnly = true;
            this.dataGridViewTransactions.RowHeadersWidth = 51;
            this.dataGridViewTransactions.RowTemplate.Height = 29;
            this.dataGridViewTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(1100, 450);
            this.dataGridViewTransactions.TabIndex = 6;
            
            // buttonAdd
            this.buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.buttonAdd.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAdd.FlatStyle = FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(12, 620);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 40);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "➕ Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            
            // buttonEdit
            this.buttonEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.buttonEdit.BackColor = System.Drawing.Color.LightBlue;
            this.buttonEdit.FlatStyle = FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(138, 620);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(120, 40);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "✏️ Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            
            // buttonDelete
            this.buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.buttonDelete.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDelete.FlatStyle = FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(264, 620);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 40);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "🗑️ Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 672);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewTransactions);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelTotalExpense);
            this.Controls.Add(this.labelTotalIncome);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SyncBudgetApp - Управление бюджетом";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}