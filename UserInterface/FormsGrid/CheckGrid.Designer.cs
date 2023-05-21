namespace UserInterface.FormsGrid
{
    partial class CheckGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckGrid));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NameCustomerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberCurdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSellerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameSellerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniqNumberSellerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPrice = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButtonDown = new System.Windows.Forms.RadioButton();
            this.radioButtonUp = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCustomerColumn,
            this.NumberCurdColumn,
            this.NameSellerColumn,
            this.SurnameSellerColumn,
            this.UniqNumberSellerColumn,
            this.DateColumn,
            this.PriceColumn});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1443, 306);
            this.dataGridView.TabIndex = 4;
            // 
            // NameCustomerColumn
            // 
            this.NameCustomerColumn.DataPropertyName = "Customer";
            this.NameCustomerColumn.HeaderText = "Имя покупателя";
            this.NameCustomerColumn.Name = "NameCustomerColumn";
            this.NameCustomerColumn.ReadOnly = true;
            this.NameCustomerColumn.Width = 200;
            // 
            // NumberCurdColumn
            // 
            this.NumberCurdColumn.DataPropertyName = "CustomerCard";
            this.NumberCurdColumn.HeaderText = "Номер карты";
            this.NumberCurdColumn.Name = "NumberCurdColumn";
            this.NumberCurdColumn.ReadOnly = true;
            this.NumberCurdColumn.Width = 200;
            // 
            // NameSellerColumn
            // 
            this.NameSellerColumn.DataPropertyName = "SellerName";
            this.NameSellerColumn.HeaderText = "Имя продавца";
            this.NameSellerColumn.Name = "NameSellerColumn";
            this.NameSellerColumn.ReadOnly = true;
            this.NameSellerColumn.Width = 200;
            // 
            // SurnameSellerColumn
            // 
            this.SurnameSellerColumn.DataPropertyName = "SellerSurname";
            this.SurnameSellerColumn.HeaderText = "Фамилия продавца";
            this.SurnameSellerColumn.Name = "SurnameSellerColumn";
            this.SurnameSellerColumn.ReadOnly = true;
            this.SurnameSellerColumn.Width = 200;
            // 
            // UniqNumberSellerColumn
            // 
            this.UniqNumberSellerColumn.DataPropertyName = "SellerNumber";
            this.UniqNumberSellerColumn.HeaderText = "Ун. номер продавца";
            this.UniqNumberSellerColumn.Name = "UniqNumberSellerColumn";
            this.UniqNumberSellerColumn.ReadOnly = true;
            this.UniqNumberSellerColumn.Width = 200;
            // 
            // DateColumn
            // 
            this.DateColumn.DataPropertyName = "CreatedData";
            this.DateColumn.HeaderText = "Дата покупки";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Width = 200;
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "Price";
            this.PriceColumn.HeaderText = "Стоимость покупки (руб.)";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 200;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCount,
            this.toolStripStatusLabelPrice});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1466, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCount
            // 
            this.toolStripStatusLabelCount.Margin = new System.Windows.Forms.Padding(0, 3, 50, 2);
            this.toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            this.toolStripStatusLabelCount.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabelCount.Text = "Кол-во:";
            // 
            // toolStripStatusLabelPrice
            // 
            this.toolStripStatusLabelPrice.Name = "toolStripStatusLabelPrice";
            this.toolStripStatusLabelPrice.Size = new System.Drawing.Size(99, 17);
            this.toolStripStatusLabelPrice.Text = "Общая выручка:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.buttonSort);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.radioButtonDown);
            this.groupBox2.Controls.Add(this.radioButtonUp);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(514, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 204);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сбросить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(52, 155);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(160, 43);
            this.buttonSort.TabIndex = 3;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Имя Покупателя",
            "Стоимость",
            "Имя Продавца",
            "Дата Покупки"});
            this.comboBox1.Location = new System.Drawing.Point(14, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(457, 32);
            this.comboBox1.TabIndex = 2;
            // 
            // radioButtonDown
            // 
            this.radioButtonDown.AutoSize = true;
            this.radioButtonDown.Location = new System.Drawing.Point(10, 111);
            this.radioButtonDown.Name = "radioButtonDown";
            this.radioButtonDown.Size = new System.Drawing.Size(169, 28);
            this.radioButtonDown.TabIndex = 1;
            this.radioButtonDown.Text = "По убыванию";
            this.radioButtonDown.UseVisualStyleBackColor = true;
            // 
            // radioButtonUp
            // 
            this.radioButtonUp.AutoSize = true;
            this.radioButtonUp.Checked = true;
            this.radioButtonUp.Location = new System.Drawing.Point(264, 111);
            this.radioButtonUp.Name = "radioButtonUp";
            this.radioButtonUp.Size = new System.Drawing.Size(203, 28);
            this.radioButtonUp.TabIndex = 0;
            this.radioButtonUp.TabStop = true;
            this.radioButtonUp.Text = "По возрастанию";
            this.radioButtonUp.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSearch);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 91);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSearch.Location = new System.Drawing.Point(12, 39);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(459, 33);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Экcпорт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(358, 447);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(131, 35);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // CheckGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 565);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1482, 604);
            this.MinimumSize = new System.Drawing.Size(1482, 604);
            this.Name = "CheckGrid";
            this.Text = "Чеки";
            this.Load += new System.EventHandler(this.CheckGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButtonDown;
        private System.Windows.Forms.RadioButton radioButtonUp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCustomerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberCurdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSellerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameSellerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniqNumberSellerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
    }
}