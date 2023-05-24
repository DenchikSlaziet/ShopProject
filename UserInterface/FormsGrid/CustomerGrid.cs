using CRMBL.Model;
using Microsoft.Office.Interop.Excel;
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
using Excel = Microsoft.Office.Interop.Excel;

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
            comboBox1.SelectedIndex = 0;
            UpdateDG();
        }

        // Кнопка "Обновить"
        private void button1_Click(object sender, EventArgs e) => UpdateDG();


        // Добавление покупателя
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                context.Customers.Add(form.Customer);
                context.SaveChanges();
                UpdateDG();
                MessageBox.Show($"Вы успешно добавили покупателя!\nИмя: {form.Customer.Name}", "Справка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Удаление покупателя
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var data = (Customer)dataGridView.Rows[dataGridView.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить {data.Name} ?\nПосле удаления покупателя информация о его покупках удалится!", 
                "Удаление Записи",
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

        // Изменение покупателя
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

        // Обновление таблицы
        private void UpdateDG()
        {
            dataGridView.DataSource = context.Customers.ToList();
            toolStripStatusLabelCountAll.Text = $"Кол-во элементов: {dataGridView.RowCount}";
        }

        // Отображение данных по выбору строки
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                textBoxName.Text = dataGridView.SelectedRows[0].Cells["ColumnName"].Value.ToString();
                textBoxNumber.Text = dataGridView.SelectedRows[0].Cells["NumberCardColumn"].Value.ToString();
            }
        }

        // Кнопка "Сортировки"
        private void buttonSort_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Имя":
                    if (radioButtonUp.Checked)
                        dataGridView.DataSource = context.Customers.OrderBy(x => x.Name).ToList();
                    else
                        dataGridView.DataSource = context.Customers.OrderByDescending(x => x.Name).ToList();
                    break;

                case "Номер Карты":
                    if (radioButtonDown.Checked)
                        dataGridView.DataSource = context.Customers.OrderByDescending(x => x.NumberCard).ToList();
                    else
                        dataGridView.DataSource = context.Customers.OrderBy(x => x.NumberCard).ToList();
                    break;

                default:
                    {
                        MessageBox.Show("Не выбран столбец!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            }
        }


        // Поиск в таблице
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var IsSearch = false;

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    dataGridView[j, i].Style.BackColor = Color.White;
                    dataGridView[j, i].Style.ForeColor = Color.Black;
                }
            }

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                dataGridView.ClearSelection();
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount-1; j++)
                    {
                        if (dataGridView[j, i].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                        {
                            IsSearch = true;
                            dataGridView[j, i].Style.BackColor = Color.Black;
                            dataGridView[j, i].Style.ForeColor = Color.White;
                        }
                    }
                }
                if (!IsSearch)
                {
                    MessageBox.Show("Ничего не найдено!", "Справка", MessageBoxButtons.OK);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }

        // Кнопка "Экспорт"
        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Экспортировать все?", "Справка", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    {
                        var xlApp = GetExcel();
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView.Columns.Count - 1; j++)
                            {
                                xlApp.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        xlApp.Visible = true;
                        break;
                    };

                case DialogResult.No:
                    {
                        var xlApp = GetExcel();
                        for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView.Columns.Count; j++)
                            {
                                xlApp.Cells[i + 2, j + 1] = dataGridView.SelectedRows[i].Cells[j].Value.ToString();
                            }
                        }
                        xlApp.Visible = true;
                        break;
                    };

                case DialogResult.Cancel:
                    return;
            }           
        }

        //Создание Excel файла
        private Excel.Application GetExcel()
        {
            Excel.Application xlApp;
            Worksheet xlSheet;
            xlApp = new Excel.Application();
            Excel.Workbook wBook;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 15;
            xlSheet = wBook.Sheets[1];
            xlSheet.Name = "Покупатели";
            xlSheet.Cells.HorizontalAlignment = 3;

            for (int j = 1; j < dataGridView.Columns.Count; j++)
            {
                xlApp.Cells[1, j] = dataGridView.Columns[j - 1].HeaderText;
            }

            return xlApp;
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            UpdateDG();
        }
    }
}
