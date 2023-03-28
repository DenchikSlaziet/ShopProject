using CRMBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Forms
{
    public partial class ProductForm : Form
    {
        public Product product;

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product pr) : this()
        {
            textBoxName.Text = pr.Name;
            numericUpDownCount.Text = pr.Count.ToString();
            numericUpDownSell.Text = pr.Price.ToString();
            this.Text = "Изменение товара";
            buttonAdd.Text = "Изменить";
            textBoxName.Enabled = false;
            label4.Visible= false;
            product= pr;
        }

        private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void numericUpDownSell_Leave(object sender, EventArgs e)
        {
            var num = (NumericUpDown)sender;
            if (num != null)
            {
                if(string.IsNullOrWhiteSpace(num.Text))
                {
                    num.Text = num.Minimum.ToString();
                }
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = !string.IsNullOrWhiteSpace(textBoxName.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                if (product == null)
                {
                    if (context.Products.Where(x => x.Name.ToLower() == textBoxName.Text.ToLower()).Count() > 0)
                    {
                        MessageBox.Show("Такой товар уже существует, вы можете изменить уже существующий!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                product = new Product()
                {
                    Name = GetString(textBoxName.Text),
                    Count = (int)numericUpDownCount.Value,
                    Price=numericUpDownSell.Value               
                };
                this.DialogResult = DialogResult.OK;
            }
        }
        private string GetString(string str)
        {
            var full = str.Split('-');
            if (full.Length > 0)
            {
                var name = "";
                foreach (var item in full)
                {
                    name += item.Substring(0, 1).ToUpper() + item.Substring(1).ToLower() + "-";
                }
                return name.Remove(name.Length - 1, 1);
            }
            return str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1).ToLower();
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '-' && l!=' ')
            {
                e.Handled = true;
            }

        }
    }
}
