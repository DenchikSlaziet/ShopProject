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
    public partial class SellerGrid : Form
    {
        private MyDbContext context;

        public SellerGrid()
        {
            InitializeComponent();
            context = new MyDbContext();
            dataGridView.AutoGenerateColumns = false;
            UpdateDG();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                context.Sellers.Add(form.seller);
                context.SaveChanges();
                UpdateDG();
                MessageBox.Show($"Вы успешно добавили продавца!\nИмя: {form.seller.Name}\nФамилия: {form.seller.Surname}",
                  "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UpdateDG()
        {
            dataGridView.DataSource = context.Sellers.ToList();
        }
    }
}
