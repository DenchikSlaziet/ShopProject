using CRMBL.Model;
using Microsoft.Office.Interop.Excel;
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
using Excel = Microsoft.Office.Interop.Excel;

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
            comboBox1.SelectedIndex = 0;
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
            ///
            dataGridView.DataSource = context.Sellers.ToList();
            toolStripStatusLabelCountAll.Text = $"Кол-во элементов: {dataGridView.RowCount}";
            toolStripStatusLabelCountAge.Text = $"Моложе 25 лет: {context.Sellers.Where(x => x.Age < 25).Count()}";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var data = (Seller)dataGridView.Rows[dataGridView.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить {data.Name} {data.Surname}(-а) ?", "Удаление Записи",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var connect = new MyDbContext())
                {
                    var seller = connect.Sellers.FirstOrDefault(x => x.SellerId == data.SellerId);
                    if (seller != null)
                    {
                        connect.Sellers.Remove(seller);
                        connect.SaveChanges();
                        UpdateDG();
                    }
                }
            }
        }

        private void buttonRefactor_Click(object sender, EventArgs e)
        {
            var data = (Seller)dataGridView.Rows[dataGridView.SelectedRows[0].Index].DataBoundItem;
            var infoform = new SellerForm(data);
            if (infoform.ShowDialog(this) == DialogResult.OK)
            {
                data.Name= infoform.seller.Name;
                data.Surname = infoform.seller.Surname;
                data.Age= infoform.seller.Age;  
                data.CompanySeller=infoform.seller.CompanySeller;
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
                textBoxSurname.Text = dataGridView.SelectedRows[0].Cells["SurnameColumn"].Value.ToString();
                textBoxNumber.Text = dataGridView.SelectedRows[0].Cells["UniqColumn"].Value.ToString();
                textBoxAge.Text = dataGridView.SelectedRows[0].Cells["AgeColumn"].Value.ToString();
                textBoxCompany.Text = dataGridView.SelectedRows[0].Cells["CompanyColumn"].Value.ToString();
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {          
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Имя":
                        if (radioButtonUp.Checked)
                            dataGridView.DataSource = context.Sellers.OrderBy(x => x.Name).ToList();
                        else
                            dataGridView.DataSource = context.Sellers.OrderByDescending(x => x.Name).ToList();
                        break;

                    case "Фамилия":
                        if (radioButtonDown.Checked)
                            dataGridView.DataSource = context.Sellers.OrderByDescending(x => x.Surname).ToList();
                        else
                            dataGridView.DataSource = context.Sellers.OrderBy(x => x.Surname).ToList();
                        break;
                    case "Возраст":
                        if (radioButtonDown.Checked)
                            dataGridView.DataSource = context.Sellers.OrderByDescending(x => x.Age).ToList();
                        else
                            dataGridView.DataSource = context.Sellers.OrderBy(x => x.Age).ToList();
                        break;
                    case "Название Компании":
                        if (radioButtonDown.Checked)
                            dataGridView.DataSource = context.Sellers.OrderByDescending(x => x.CompanySeller).ToList();
                        else
                            dataGridView.DataSource = context.Sellers.OrderBy(x => x.CompanySeller).ToList();
                        break;
                    case "Уникальный номер":
                        if (radioButtonDown.Checked)
                            dataGridView.DataSource = context.Sellers.OrderByDescending(x => x.UniqueNumber).ToList();
                        else
                            dataGridView.DataSource = context.Sellers.OrderBy(x => x.UniqueNumber).ToList();
                        break;
                    default:
                        {
                            MessageBox.Show("Не выбран столбец!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)
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
            xlSheet.Name = "Продавцы";
            xlSheet.Cells.HorizontalAlignment = 3;
            for (int j = 1; j < dataGridView.Columns.Count; j++)
            {
                xlApp.Cells[1, j] = dataGridView.Columns[j - 1].HeaderText;
            }
            return xlApp;
        }
    }
}
