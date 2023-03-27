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

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = !string.IsNullOrWhiteSpace(textBoxName.Text) && maskedTextBoxNumberCard.MaskCompleted;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                if (context.Customers.Where(x=>x.NumberCard==maskedTextBoxNumberCard.Text).Count()>0)
                {
                    MessageBox.Show("Данная карта уже существует!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                Customer = new Customer()
                {
                    Name = textBoxName.Text,
                    NumberCard = maskedTextBoxNumberCard.Text,
                };
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
