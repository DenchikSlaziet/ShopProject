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

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = !string.IsNullOrWhiteSpace(textBoxName.Text) && !string.IsNullOrWhiteSpace(numericUpDownAge.Text) &&
                !string.IsNullOrWhiteSpace(textBoxSurname.Text) && !string.IsNullOrWhiteSpace(textBoxCompany.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                if (context.Sellers.Where(x => x.Name == textBoxName.Text && x.Surname==textBoxSurname.Text &&
                x.Age==numericUpDownAge.Value && x.CompanySeller==textBoxCompany.Text).Count() > 0)
                {
                    MessageBox.Show("Точно такой-же продавец уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                seller = new Seller()
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Age = (int)numericUpDownAge.Value,
                    CompanySeller = textBoxCompany.Text,
                };
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void numericUpDownAge_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numericUpDownAge.Text))
            {
                numericUpDownAge.Text = numericUpDownAge.Minimum.ToString();
            }
        }

    }
}

