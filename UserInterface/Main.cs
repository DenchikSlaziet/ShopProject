using CRMBL.Model;
using System;
using System.Windows.Forms;
using UserInterface.Forms;
using UserInterface.FormsGrid;

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

        private  void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pg = new ProductGrid();
            pg.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sg = new SellerGrid();
            sg.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cg = new CustomerGrid();
            cg.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catg = new CheckGrid();
            catg.Show();
        }

        private void CustomerAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                context.Customers.Add(form.Customer);
                context.SaveChanges();
                MessageBox.Show($"Вы успешно добавили покупателя!\nИмя: {form.Customer.Name}", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProductAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                context.Sellers.Add(form.seller);
                context.SaveChanges();
                MessageBox.Show($"Вы успешно добавили продавца!\nИмя: {form.seller.Name}\nФамилия: {form.seller.Surname}",
                    "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SellerAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                context.Products.Add(form.product);
                context.SaveChanges();
                MessageBox.Show($"Вы успешно добавили товар!\nНаиминование: {form.product.Name}\nЦена: {form.product.Price}",
                    "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void сущностиToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Просмотр существующих таблиц";
        }

        private void сущностиToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void товарыToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Просмотр Товаров";
        }

        private void покупателиToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Просмотр Покупателей";
        }

        private void продавцыToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Просмотр Продавцов";
        }

        private void чекиToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Просмотр Чеков";
        }

        private void моделированиеToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Просмотр работоспособности магазина";
        }

        private void справкаToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Просмотр информации о приложении";
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new InformationForm();
            form.ShowDialog();
        }

        private void просмотрСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Справка.docx");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Вы точно хотите выйти?","Вопрос",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Close();
            }
        }

        private void выходToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выйти из приложения";
        }

        private void моделированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mf = new ModelForm();
            mf.Show();
        }
    }
}
