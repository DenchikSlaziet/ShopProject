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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NameCustomerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberCurdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSellerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameSellerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniqNumberSellerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCustomerColumn,
            this.NumberCurdColumn,
            this.NameSellerColumn,
            this.SurnameSellerColumn,
            this.UniqNumberSellerColumn,
            this.DateColumn});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(643, 306);
            this.dataGridView.TabIndex = 4;
            // 
            // NameCustomerColumn
            // 
            this.NameCustomerColumn.HeaderText = "Имя покупателя";
            this.NameCustomerColumn.Name = "NameCustomerColumn";
            this.NameCustomerColumn.ReadOnly = true;
            // 
            // NumberCurdColumn
            // 
            this.NumberCurdColumn.HeaderText = "Номер карты";
            this.NumberCurdColumn.Name = "NumberCurdColumn";
            this.NumberCurdColumn.ReadOnly = true;
            // 
            // NameSellerColumn
            // 
            this.NameSellerColumn.HeaderText = "Имя продавца";
            this.NameSellerColumn.Name = "NameSellerColumn";
            this.NameSellerColumn.ReadOnly = true;
            // 
            // SurnameSellerColumn
            // 
            this.SurnameSellerColumn.HeaderText = "Фамилия продавца";
            this.SurnameSellerColumn.Name = "SurnameSellerColumn";
            this.SurnameSellerColumn.ReadOnly = true;
            // 
            // UniqNumberSellerColumn
            // 
            this.UniqNumberSellerColumn.HeaderText = "Ун. номер продавца";
            this.UniqNumberSellerColumn.Name = "UniqNumberSellerColumn";
            this.UniqNumberSellerColumn.ReadOnly = true;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Дата покупки";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // CheckGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.dataGridView);
            this.Name = "CheckGrid";
            this.Text = "Чеки";
            this.Load += new System.EventHandler(this.CheckGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCustomerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberCurdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSellerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameSellerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniqNumberSellerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
    }
}