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
            dataGridView.Update();
            toolStripStatusLabelCountAll.Text = $"Кол-во элементов: {dataGridView.RowCount}";
            toolStripStatusLabelCountCount.Text = $"Кол-во меньше 50: {context.Products.Where(x => x.Count < 50).Count()}";
            toolStripStatusLabelCountSell.Text = $"Дешевле 100 рублей: {context.Products.Where(x => x.Price < 100).Count()}";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var data = (Product)dataGridView.Rows[dataGridView.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить {data.Name}, стоимостью {data.Price}?", "Удаление Записи",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var connect = new MyDbContext())
                {
                    var product = connect.Products.FirstOrDefault(x => x.ProductId == data.ProductId);
                    if (product != null)
                    {
                        connect.Products.Remove(product);
                        connect.SaveChanges();
                        UpdateDG();
                    }
                }
            }
        }

        private void buttonRefactor_Click(object sender, EventArgs e)
        {
            var data = (Product)dataGridView.Rows[dataGridView.SelectedRows[0].Index].DataBoundItem;
            var infoform = new ProductForm(data);
            if (infoform.ShowDialog(this) == DialogResult.OK)
            {
                data.Name = infoform.product.Name;
                data.Price=infoform.product.Price;
                data.Count=infoform.product.Count;
                context.SaveChanges();
                UpdateDG();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateDG();
        }
    }
}
