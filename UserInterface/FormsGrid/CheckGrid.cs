using CRMBL.Model;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace UserInterface.FormsGrid
{
    public partial class CheckGrid : Form
    {
        private MyDbContext context;
        public CheckGrid()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            comboBox1.SelectedIndex = 0;
            context = new MyDbContext();
        }

        private void CheckGrid_Load(object sender, EventArgs e)
        {          
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            var count = context.Checks.Count();
            toolStripStatusLabelCount.Text = $"Кол-во: {count}";
            if (count > 0)
            {
                toolStripStatusLabelPrice.Text = $"Общая выручка: {context.Checks.Sum(x => x.Price)} руб.";
            }
            dataGridView.DataSource = context.Checks.ToList();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {

                case "Имя Покупателя":
                    if (radioButtonUp.Checked)
                        dataGridView.DataSource = context.Checks.OrderBy(x => x.Customer).ToList();
                    else
                        dataGridView.DataSource = context.Checks.OrderByDescending(x => x.Customer).ToList();
                    break;

                case "Стоимость":
                    if (radioButtonUp.Checked)
                        dataGridView.DataSource = context.Checks.OrderBy(x => x.Price).ToList();
                    else
                        dataGridView.DataSource = context.Checks.OrderByDescending(x => x.Price).ToList();
                    break;

                case "Имя Продавца":
                    if (radioButtonUp.Checked)
                        dataGridView.DataSource = context.Checks.OrderBy(x => x.Seller).ToList();
                    else
                        dataGridView.DataSource = context.Checks.OrderByDescending(x => x.Seller).ToList();
                    break;

                case "Дата Покупки":
                    if (radioButtonUp.Checked)
                        dataGridView.DataSource = context.Checks.OrderBy(x => x.CreatedData).ToList();
                    else
                        dataGridView.DataSource = context.Checks.OrderByDescending(x => x.CreatedData).ToList();
                    break;

                default:
                    MessageBox.Show("Такого столбца нет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
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
    
        private void button2_Click(object sender, EventArgs e)
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
                            for (int j = 0; j < dataGridView.Columns.Count - 1; j++)
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
        private Excel.Application GetExcel()
        {
            Excel.Application xlApp;
            Worksheet xlSheet;
            xlApp = new Excel.Application();
            Excel.Workbook wBook;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 15;
            xlSheet = wBook.Sheets[1];
            xlSheet.Name = "Чеки";
            xlSheet.Cells.HorizontalAlignment = 3;
            for (int j = 1; j < dataGridView.Columns.Count; j++)
            {
                xlApp.Cells[1, j] = dataGridView.Columns[j - 1].HeaderText;
            }
            return xlApp;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateStatus();
        }

    }
}
