namespace UserInterface.FormsGrid
{
    partial class SellerGrid
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
            this.buttonRefactor = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniqColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChecksColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCountAll = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCountAge = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRefactor
            // 
            this.buttonRefactor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefactor.Location = new System.Drawing.Point(183, 390);
            this.buttonRefactor.Name = "buttonRefactor";
            this.buttonRefactor.Size = new System.Drawing.Size(131, 35);
            this.buttonRefactor.TabIndex = 15;
            this.buttonRefactor.Text = "Изменить";
            this.buttonRefactor.UseVisualStyleBackColor = true;
            this.buttonRefactor.Click += new System.EventHandler(this.buttonRefactor_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(358, 390);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 35);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Удалить ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 390);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 35);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.SurnameColumn,
            this.UniqColumn,
            this.AgeColumn,
            this.CompanyColumn,
            this.ChecksColumn});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1143, 357);
            this.dataGridView.TabIndex = 12;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(553, 390);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(131, 35);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.MinimumWidth = 100;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 200;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.DataPropertyName = "Surname";
            this.SurnameColumn.HeaderText = "Фамилия";
            this.SurnameColumn.MinimumWidth = 100;
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.ReadOnly = true;
            this.SurnameColumn.Width = 200;
            // 
            // UniqColumn
            // 
            this.UniqColumn.DataPropertyName = "UniqueNumber";
            this.UniqColumn.HeaderText = "Уникальный Номер";
            this.UniqColumn.Name = "UniqColumn";
            this.UniqColumn.ReadOnly = true;
            this.UniqColumn.Width = 200;
            // 
            // AgeColumn
            // 
            this.AgeColumn.DataPropertyName = "Age";
            this.AgeColumn.HeaderText = "Возраст";
            this.AgeColumn.MinimumWidth = 50;
            this.AgeColumn.Name = "AgeColumn";
            this.AgeColumn.ReadOnly = true;
            // 
            // CompanyColumn
            // 
            this.CompanyColumn.DataPropertyName = "CompanySeller";
            this.CompanyColumn.HeaderText = "Компания";
            this.CompanyColumn.MinimumWidth = 100;
            this.CompanyColumn.Name = "CompanyColumn";
            this.CompanyColumn.ReadOnly = true;
            this.CompanyColumn.Width = 200;
            // 
            // ChecksColumn
            // 
            this.ChecksColumn.DataPropertyName = "Checks";
            this.ChecksColumn.HeaderText = "Чеки";
            this.ChecksColumn.MinimumWidth = 100;
            this.ChecksColumn.Name = "ChecksColumn";
            this.ChecksColumn.ReadOnly = true;
            this.ChecksColumn.Width = 200;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCountAll,
            this.toolStripStatusLabelCountAge});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1172, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCountAll
            // 
            this.toolStripStatusLabelCountAll.Margin = new System.Windows.Forms.Padding(0, 3, 40, 2);
            this.toolStripStatusLabelCountAll.Name = "toolStripStatusLabelCountAll";
            this.toolStripStatusLabelCountAll.Size = new System.Drawing.Size(111, 17);
            this.toolStripStatusLabelCountAll.Text = "Кол-во элементов:";
            // 
            // toolStripStatusLabelCountAge
            // 
            this.toolStripStatusLabelCountAge.Name = "toolStripStatusLabelCountAge";
            this.toolStripStatusLabelCountAge.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabelCountAge.Text = "Моложе 25 лет:";
            // 
            // SellerGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 467);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRefactor);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView);
            this.Name = "SellerGrid";
            this.Text = "Продавцы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefactor;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniqColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChecksColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCountAll;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCountAge;
    }
}