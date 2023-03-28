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
    public partial class SellerForm : Form
    {
        public Seller seller;
        public SellerForm()
        {
            InitializeComponent();
        }

        public SellerForm(Seller sl):this()
        {
            textBoxName.Text = sl.Name;
            textBoxSurname.Text = sl.Surname;
            textBoxCompany.Text = sl.CompanySeller;
            numericUpDownAge.Text=sl.Age.ToString();
            maskedTextBox1.Text = sl.UniqueNumber;
            buttonAdd.Text = "Изменить";
            this.Text = "Изменить Продаца";
            label6.Visible= false;
            seller = sl;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = !string.IsNullOrWhiteSpace(textBoxName.Text) && !string.IsNullOrWhiteSpace(numericUpDownAge.Text) &&
                !string.IsNullOrWhiteSpace(textBoxSurname.Text) && !string.IsNullOrWhiteSpace(textBoxCompany.Text) && maskedTextBox1.MaskCompleted;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                if (seller == null)
                {
                    if (context.Sellers.Where(x=>x.UniqueNumber==maskedTextBox1.Text).Count() > 0)
                    {
                        MessageBox.Show("Точно такой-же продавец уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                seller = new Seller()
                {
                    Name = GetString(textBoxName.Text),
                    Surname = GetString(textBoxSurname.Text),
                    Age = (int)numericUpDownAge.Value,
                    CompanySeller = textBoxCompany.Text,
                    UniqueNumber= maskedTextBox1.Text,
                };
                this.DialogResult = DialogResult.OK;
            }
        }

        private void numericUpDownAge_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numericUpDownAge.Text))
            {
                numericUpDownAge.Text = numericUpDownAge.Minimum.ToString();
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
            if ((l < 'А' || l > 'я') && l != '\b' && l != '-')
            {
                e.Handled = true;
            }

        }
    }
}

