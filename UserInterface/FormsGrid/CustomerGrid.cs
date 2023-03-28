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
            toolStripStatusLabelCountAll.Text = $"Кол-во элементов: {dataGridView.RowCount}";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var data = (Customer)dataGridView.Rows[dataGridView.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить {data.Name} ?", "Удаление Записи",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(var connect = new MyDbContext())
                {
                    var customer = connect.Customers.FirstOrDefault(x => x.CustomerId == data.CustomerId);
                    if (customer != null)
                    {
                        connect.Customers.Remove(customer);
                        connect.SaveChanges();
                        UpdateDG();
                    }
                }
            }
        }

        private void buttonRefactor_Click(object sender, EventArgs e)
        {
            var data = (Customer)dataGridView.Rows[dataGridView.SelectedRows[0].Index].DataBoundItem;
            var infoform = new CustomerForm(data);
            if (infoform.ShowDialog(this) == DialogResult.OK)
            {
                data.Name = infoform.Customer.Name;
                data.NumberCard = infoform.Customer.NumberCard;
                context.SaveChanges();
                UpdateDG();
            }

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
                textBoxName.Text = dataGridView.SelectedRows[0].Cells["ColumnName"].Value.ToString();
                textBoxNumber.Text= dataGridView.SelectedRows[0].Cells["NumberCardColumn"].Value.ToString();
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            //DataGridViewColumn COL;
            //switch (comboBox1.SelectedItem.ToString())
            //{
            //    case "Имя":
            //        COL = dataGridView.Columns["ColumnName"];
            //        break;
            //    case "Номер Карты":
            //        COL = dataGridView.Columns["NumberCardColumn"];
            //        break;
            //    default:
            //        {
            //            MessageBox.Show("Не выбран столбец!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //}
            //if(radioButtonUp.Checked)
            //{
            //    dataGridView.Sort(COL,ListSortDirection.Ascending);
            //}
            //else
            //{
            //    dataGridView.Sort(COL,ListSortDirection.Descending);
            //}
        }
    }
}
