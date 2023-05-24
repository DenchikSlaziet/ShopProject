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
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; set; }

        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(Customer customer) : this()
        {
            textBoxName.Text = customer.Name;
            maskedTextBoxNumberCard.Text = customer.NumberCard;
            buttonAdd.Text = "Изменить";
            this.Text = "Изменить покупателя";
            maskedTextBoxNumberCard.Enabled = false;
            label3.Visible = false;
            Icon = Properties.Resources.Convert;
            Customer=customer;
        }

        public CustomerForm(string name, string numberCard):this()
        {
            textBoxName.Text = name;
            maskedTextBoxNumberCard.Text = numberCard;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = !string.IsNullOrWhiteSpace(textBoxName.Text) && maskedTextBoxNumberCard.MaskCompleted;
        }

        // Кнопка "Добавить"
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                if (Customer == null)
                {
                    if (context.Customers.Where(x => x.NumberCard == maskedTextBoxNumberCard.Text).Count() > 0)
                    {
                        MessageBox.Show("Данная карта уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Customer = new Customer()
                {
                    Name = GetString(textBoxName.Text),
                    NumberCard = maskedTextBoxNumberCard.Text,
                };

                this.DialogResult = DialogResult.OK;
            }
        }

        // Метод дающий корректное имя
        private string GetString(string str)
        {
            var full = str.Split('-');
            if (full.Length > 0)
            {
                var name = new StringBuilder();
                foreach (var item in full)
                {
                    name.Append(item.Substring(0, 1).ToUpper() + item.Substring(1).ToLower() + "-");
                }
                return name.Remove(name.Length-1,1).ToString();
            }
            return str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1).ToLower();
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l!='-')
            {
                e.Handled = true;
            }
        }
    }
}
