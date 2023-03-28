using CRMBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Forms;

namespace UserInterface.FormsGrid
{
    public partial class ProductGrid : Form
    {
        private MyDbContext context;
        public ProductGrid()
        {
            InitializeComponent();
            context=new MyDbContext();
            dataGridView.AutoGenerateColumns = false;
            UpdateDG();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                context.Products.Add(form.product);
                context.SaveChanges();
                UpdateDG();
                MessageBox.Show($"Вы успешно добавили товар!\nНаиминование: {form.product.Name}\nЦена: {form.product.Price}",
                   "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UpdateDG()
        {
            dataGridView.DataSource = context.Products.ToList();
        }
    }
}
