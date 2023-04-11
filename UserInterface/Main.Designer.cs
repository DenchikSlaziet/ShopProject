namespace UserInterface
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сущностиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.продавцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.чекиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моделированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сущностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellerAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сущностиToolStripMenuItem1,
            this.моделированиеToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сущностиToolStripMenuItem1
            // 
            this.сущностиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарыToolStripMenuItem,
            this.покупателиToolStripMenuItem,
            this.продавцыToolStripMenuItem,
            this.чекиToolStripMenuItem});
            this.сущностиToolStripMenuItem1.Name = "сущностиToolStripMenuItem1";
            this.сущностиToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.сущностиToolStripMenuItem1.Text = "Сущности";
            this.сущностиToolStripMenuItem1.MouseEnter += new System.EventHandler(this.сущностиToolStripMenuItem1_MouseEnter);
            this.сущностиToolStripMenuItem1.MouseLeave += new System.EventHandler(this.сущностиToolStripMenuItem1_MouseLeave);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.товарыToolStripMenuItem.Text = "Товары";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            this.товарыToolStripMenuItem.MouseEnter += new System.EventHandler(this.товарыToolStripMenuItem_MouseEnter);
            this.товарыToolStripMenuItem.MouseLeave += new System.EventHandler(this.сущностиToolStripMenuItem1_MouseLeave);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.ProductAddToolStripMenuItem_Click);
            // 
            // покупателиToolStripMenuItem
            // 
            this.покупателиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1});
            this.покупателиToolStripMenuItem.Name = "покупателиToolStripMenuItem";
            this.покупателиToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.покупателиToolStripMenuItem.Text = "Покупатели";
            this.покупателиToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            this.покупателиToolStripMenuItem.MouseEnter += new System.EventHandler(this.покупателиToolStripMenuItem_MouseEnter);
            this.покупателиToolStripMenuItem.MouseLeave += new System.EventHandler(this.сущностиToolStripMenuItem1_MouseLeave);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.CustomerAddToolStripMenuItem_Click);
            // 
            // продавцыToolStripMenuItem
            // 
            this.продавцыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem2});
            this.продавцыToolStripMenuItem.Name = "продавцыToolStripMenuItem";
            this.продавцыToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.продавцыToolStripMenuItem.Text = "Продавцы";
            this.продавцыToolStripMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            this.продавцыToolStripMenuItem.MouseEnter += new System.EventHandler(this.продавцыToolStripMenuItem_MouseEnter);
            this.продавцыToolStripMenuItem.MouseLeave += new System.EventHandler(this.сущностиToolStripMenuItem1_MouseLeave);
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            this.добавитьToolStripMenuItem2.Click += new System.EventHandler(this.SellerAddToolStripMenuItem_Click);
            // 
            // чекиToolStripMenuItem
            // 
            this.чекиToolStripMenuItem.Name = "чекиToolStripMenuItem";
            this.чекиToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.чекиToolStripMenuItem.Text = "Чеки";
            this.чекиToolStripMenuItem.Click += new System.EventHandler(this.CheckToolStripMenuItem_Click);
            this.чекиToolStripMenuItem.MouseEnter += new System.EventHandler(this.чекиToolStripMenuItem_MouseEnter);
            this.чекиToolStripMenuItem.MouseLeave += new System.EventHandler(this.сущностиToolStripMenuItem1_MouseLeave);
            // 
            // моделированиеToolStripMenuItem
            // 
            this.моделированиеToolStripMenuItem.Name = "моделированиеToolStripMenuItem";
            this.моделированиеToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.моделированиеToolStripMenuItem.Text = "Моделирование";
            this.моделированиеToolStripMenuItem.Click += new System.EventHandler(this.моделированиеToolStripMenuItem_Click);
            this.моделированиеToolStripMenuItem.MouseEnter += new System.EventHandler(this.моделированиеToolStripMenuItem_MouseEnter);
            this.моделированиеToolStripMenuItem.MouseLeave += new System.EventHandler(this.сущностиToolStripMenuItem1_MouseLeave);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.просмотрСправкиToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.MouseEnter += new System.EventHandler(this.справкаToolStripMenuItem_MouseEnter);
            this.справкаToolStripMenuItem.MouseLeave += new System.EventHandler(this.сущностиToolStripMenuItem1_MouseLeave);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // просмотрСправкиToolStripMenuItem
            // 
            this.просмотрСправкиToolStripMenuItem.Name = "просмотрСправкиToolStripMenuItem";
            this.просмотрСправкиToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.просмотрСправкиToolStripMenuItem.Text = "Просмотр Справки";
            this.просмотрСправкиToolStripMenuItem.Click += new System.EventHandler(this.просмотрСправкиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            this.выходToolStripMenuItem.MouseEnter += new System.EventHandler(this.выходToolStripMenuItem_MouseEnter);
            this.выходToolStripMenuItem.MouseLeave += new System.EventHandler(this.сущностиToolStripMenuItem1_MouseLeave);
            // 
            // сущностиToolStripMenuItem
            // 
            this.сущностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductToolStripMenuItem,
            this.SellerToolStripMenuItem,
            this.CustomerToolStripMenuItem,
            this.CheckToolStripMenuItem});
            this.сущностиToolStripMenuItem.Name = "сущностиToolStripMenuItem";
            this.сущностиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.сущностиToolStripMenuItem.Text = "Сущности";
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SellerAddToolStripMenuItem});
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            this.ProductToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ProductToolStripMenuItem.Text = "Товар";
            this.ProductToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // SellerAddToolStripMenuItem
            // 
            this.SellerAddToolStripMenuItem.Name = "SellerAddToolStripMenuItem";
            this.SellerAddToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.SellerAddToolStripMenuItem.Text = "Добавить";
            this.SellerAddToolStripMenuItem.Click += new System.EventHandler(this.SellerAddToolStripMenuItem_Click);
            // 
            // SellerToolStripMenuItem
            // 
            this.SellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductAddToolStripMenuItem});
            this.SellerToolStripMenuItem.Name = "SellerToolStripMenuItem";
            this.SellerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.SellerToolStripMenuItem.Text = "Продавец";
            this.SellerToolStripMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            // 
            // ProductAddToolStripMenuItem
            // 
            this.ProductAddToolStripMenuItem.Name = "ProductAddToolStripMenuItem";
            this.ProductAddToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ProductAddToolStripMenuItem.Text = "Добавить";
            this.ProductAddToolStripMenuItem.Click += new System.EventHandler(this.ProductAddToolStripMenuItem_Click);
            // 
            // CustomerToolStripMenuItem
            // 
            this.CustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerAddToolStripMenuItem});
            this.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            this.CustomerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.CustomerToolStripMenuItem.Text = "Покупатель";
            this.CustomerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // CustomerAddToolStripMenuItem
            // 
            this.CustomerAddToolStripMenuItem.Name = "CustomerAddToolStripMenuItem";
            this.CustomerAddToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.CustomerAddToolStripMenuItem.Text = "Добавить";
            this.CustomerAddToolStripMenuItem.Click += new System.EventHandler(this.CustomerAddToolStripMenuItem_Click);
            // 
            // CheckToolStripMenuItem
            // 
            this.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem";
            this.CheckToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.CheckToolStripMenuItem.Text = "Чек";
            this.CheckToolStripMenuItem.Click += new System.EventHandler(this.CheckToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Главная";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сущностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellerAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сущностиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продавцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem чекиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моделированиеToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрСправкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

