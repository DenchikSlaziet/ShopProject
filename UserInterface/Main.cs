﻿using CRMBL.Model;
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

namespace UserInterface
{
    public partial class Main : Form
    {
        MyDbContext context;

        public Main()
        {
            InitializeComponent();
            context = new MyDbContext();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(context.Products);
            catalogProduct.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(context.Sellers);
            catalogSeller.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(context.Customers);
            catalogCustomer.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCheck = new Catalog<Check>(context.Checks);
            catalogCheck.Show();
        }

        private void CustomerAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                context.Customers.Add(form.Customer);
                context.SaveChanges();
                MessageBox.Show("Вы успешно добавили покупателя!", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProductAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                context.Sellers.Add(form.seller);
                context.SaveChanges();
                MessageBox.Show("Вы успешно добавили продавца!", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SellerAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                context.Products.Add(form.product);
                context.SaveChanges();
                MessageBox.Show("Вы успешно добавили товар!", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
