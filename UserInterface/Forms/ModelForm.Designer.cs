namespace UserInterface.Forms
{
    partial class ModelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelForm));
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownSpeedCustomer = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeedSeller = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedSeller)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(798, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownSpeedCustomer
            // 
            this.numericUpDownSpeedCustomer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSpeedCustomer.Location = new System.Drawing.Point(824, 49);
            this.numericUpDownSpeedCustomer.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSpeedCustomer.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSpeedCustomer.Name = "numericUpDownSpeedCustomer";
            this.numericUpDownSpeedCustomer.Size = new System.Drawing.Size(179, 31);
            this.numericUpDownSpeedCustomer.TabIndex = 1;
            this.numericUpDownSpeedCustomer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSpeedCustomer.ValueChanged += new System.EventHandler(this.numericUpDownSpeedSeller_ValueChanged);
            // 
            // numericUpDownSpeedSeller
            // 
            this.numericUpDownSpeedSeller.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSpeedSeller.Location = new System.Drawing.Point(824, 12);
            this.numericUpDownSpeedSeller.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSpeedSeller.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSpeedSeller.Name = "numericUpDownSpeedSeller";
            this.numericUpDownSpeedSeller.Size = new System.Drawing.Size(179, 31);
            this.numericUpDownSpeedSeller.TabIndex = 2;
            this.numericUpDownSpeedSeller.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSpeedSeller.ValueChanged += new System.EventHandler(this.numericUpDownSpeedCustomer_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(599, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Скорость Клиентов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(588, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Скорость Продавца:";
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSpeedSeller);
            this.Controls.Add(this.numericUpDownSpeedCustomer);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1041, 489);
            this.MinimumSize = new System.Drawing.Size(1041, 489);
            this.Name = "ModelForm";
            this.Text = "Моделирование";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelForm_FormClosing);
            this.Load += new System.EventHandler(this.ModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedSeller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedCustomer;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedSeller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}