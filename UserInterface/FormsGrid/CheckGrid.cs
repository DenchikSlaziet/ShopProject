using CRMBL.Model;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private const string PATH = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ShopDB;Integrated Security=True;";
        private SqlConnection connection = new SqlConnection(PATH);
        private SqlCommand command;
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
            SortDGV("SELECT Customers.Name, Customers.NumberCard, Sellers.Name , Sellers.Surname , Sellers.UniqueNumber , Checks.CreatedData, Checks.Price FROM Customers,Sellers,Checks WHERE Customers.CustomerId = Checks.CustomerId AND Sellers.SellerId = Checks.SellerId;");
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            toolStripStatusLabelCount.Text = $"Кол-во: {context.Checks.Count()}";
            toolStripStatusLabelPrice.Text = $"Общая выручка: {context.Checks.Sum(x => x.Price)} руб.";
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {

                case "Имя Покупателя":
                        SortDGV("SELECT Customers.Name, Customers.NumberCard, Sellers.Name , Sellers.Surname , Sellers.UniqueNumber , Checks.CreatedData, Checks.Price FROM Customers,Sellers,Checks WHERE Customers.CustomerId = Checks.CustomerId AND Sellers.SellerId = Checks.SellerId ORDER BY Customers.Name");
                        break;

                case "Стоимость":
                        SortDGV("SELECT Customers.Name, Customers.NumberCard, Sellers.Name , Sellers.Surname , Sellers.UniqueNumber , Checks.CreatedData, Checks.Price FROM Customers,Sellers,Checks WHERE Customers.CustomerId = Checks.CustomerId AND Sellers.SellerId = Checks.SellerId ORDER BY Checks.Price");
                    break;

                case "Имя Продавца":
                        SortDGV("SELECT Customers.Name, Customers.NumberCard, Sellers.Name , Sellers.Surname , Sellers.UniqueNumber , Checks.CreatedData, Checks.Price FROM Customers,Sellers,Checks WHERE Customers.CustomerId = Checks.CustomerId AND Sellers.SellerId = Checks.SellerId ORDER BY Sellers.Name");
                    break;

                case "Дата Покупки":
                        SortDGV("SELECT Customers.Name, Customers.NumberCard, Sellers.Name , Sellers.Surname , Sellers.UniqueNumber , Checks.CreatedData, Checks.Price FROM Customers,Sellers,Checks WHERE Customers.CustomerId = Checks.CustomerId AND Sellers.SellerId = Checks.SellerId ORDER BY Checks.CreatedData");
                    break;
                default:
                    MessageBox.Show("Такого столбца нет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.RowCount-1; i++)
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
                for (int i = 0; i < dataGridView.RowCount-1; i++)
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

        private void SortDGV(string query)
        {    
            dataGridView.Rows.Clear();
            connection.Open();
            if (query.Contains("ORDER BY"))
            {
                if (radioButtonUp.Checked)
                {
                    query += " ASC;";
                }
                else
                {
                    query += " DESC;";
                }
            }

            command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();
            var list = new List<string[]>();

            while (reader.Read())
            {
                list.Add(new string[7]);

                list[list.Count - 1][0] = reader[0].ToString();
                list[list.Count - 1][1] = reader[1].ToString();
                list[list.Count - 1][2] = reader[2].ToString();
                list[list.Count - 1][3] = reader[3].ToString();
                list[list.Count - 1][4] = reader[4].ToString();
                list[list.Count - 1][5] = reader[5].ToString();
                list[list.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();
            connection.Close();

            foreach (var item in list)
            {
                dataGridView.Rows.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SortDGV("SELECT Customers.Name, Customers.NumberCard, Sellers.Name , Sellers.Surname , Sellers.UniqueNumber , Checks.CreatedData, Checks.Price FROM Customers,Sellers,Checks WHERE Customers.CustomerId = Checks.CustomerId AND Sellers.SellerId = Checks.SellerId;");
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
            SortDGV("SELECT Customers.Name, Customers.NumberCard, Sellers.Name , Sellers.Surname , Sellers.UniqueNumber , Checks.CreatedData, Checks.Price FROM Customers,Sellers,Checks WHERE Customers.CustomerId = Checks.CustomerId AND Sellers.SellerId = Checks.SellerId;");
        }
    }
}
