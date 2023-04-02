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
            comboBox1.SelectedIndex = 0;
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

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                textBoxName.Text = dataGridView.SelectedRows[0].Cells["NameColumn"].Value.ToString();
                textBoxPrice.Text = dataGridView.SelectedRows[0].Cells["PriceColumn"].Value.ToString()+" руб.";
                textBoxCount.Text = dataGridView.SelectedRows[0].Cells["CountColumn"].Value.ToString()+" шт.";
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Наиминование":
                        if (radioButtonUp.Checked)
                            dataGridView.DataSource = context.Products.OrderBy(x => x.Name).ToList();
                        else
                            dataGridView.DataSource = context.Products.OrderByDescending(x => x.Name).ToList();
                        break;

                    case "Стоимость":
                        if (radioButtonDown.Checked)
                            dataGridView.DataSource = context.Products.OrderByDescending(x => x.Price).ToList();
                        else
                            dataGridView.DataSource = context.Products.OrderBy(x => x.Price).ToList();
                        break;
                    case "Кол-во":
                        if (radioButtonDown.Checked)
                            dataGridView.DataSource = context.Products.OrderByDescending(x => x.Count).ToList();
                        else
                            dataGridView.DataSource = context.Products.OrderBy(x => x.Count).ToList();
                        break;

                    default:
                        {
                            MessageBox.Show("Такого столбца нет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    dataGridView[j, i].Style.BackColor = Color.White;
                    dataGridView[j, i].Style.ForeColor = Color.Black;
                }
            }

            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                dataGridView.ClearSelection();
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount - 1; j++)
                    {
                        if (dataGridView[j, i].Value.ToString().ToLower().Contains(textBoxSearch.Text.ToLower()))
                        {
                            dataGridView[j, i].Style.BackColor = Color.Black;
                            dataGridView[j, i].Style.ForeColor = Color.White;
                        }
                    }
                }
            }
        }
    }
}
