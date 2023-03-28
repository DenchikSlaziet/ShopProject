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
using UserInterface.Forms;

namespace UserInterface.FormsGrid
{
    public partial class CustomerGrid : Form
    {
        private MyDbContext context;
        public CustomerGrid()
        {
            InitializeComponent();
            context = new MyDbContext();
            dataGridView.AutoGenerateColumns = false;
            UpdateDG();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDG();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                context.Customers.Add(form.Customer);
                context.SaveChanges();
                UpdateDG();
                MessageBox.Show($"Вы успешно добавили покупателя!\nИмя: {form.Customer.Name}", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateDG()
        {
            dataGridView.DataSource = context.Customers.ToList();
        }
    }
}
