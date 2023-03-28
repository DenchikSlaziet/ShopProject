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
    }
}
