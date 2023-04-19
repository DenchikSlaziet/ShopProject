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
    public partial class LoginForm : Form
    {
        MyDbContext context;
        public Customer Customer { get; set; }
        public LoginForm(MyDbContext context)
        {
            InitializeComponent();
            this.context = context ?? new MyDbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Name = GetString(textBoxName.Text);
            if (context.Customers.Where(x=>x.Name==Name && x.NumberCard==maskedTextBoxNumberCard.Text).Count()>0)
            {
                MessageBox.Show($"Добро пожаловать {Name}!","Вход",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Customer = context.Customers.First(x => x.NumberCard == maskedTextBoxNumberCard.Text);
                DialogResult =DialogResult.OK;
            }
            else
            {
                if(MessageBox.Show($"Логин или пароль неверны!\nЖелаете ли вы добавить себя в базу?", "Вход",MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
                {
                    var form = new CustomerForm();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Customer = form.Customer;
                        context.Customers.Add(Customer);
                        context.SaveChanges();
                        DialogResult = DialogResult.OK;
                    }
                }
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

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = !string.IsNullOrWhiteSpace(textBoxName.Text) && maskedTextBoxNumberCard.MaskCompleted;
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
