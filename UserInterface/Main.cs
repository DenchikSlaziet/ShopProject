using CRMBL.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Forms;
using UserInterface.FormsGrid;

namespace UserInterface
{
    public partial class Main : Form
    {
        MyDbContext context;
        Cart cart;
        Customer customer;
        CashDesk cashDesk;
        Random rnd = new Random();

        public Main()
        {
            InitializeComponent();
            context = new MyDbContext();
            cart = new Cart(customer);    
            var item = rnd.Next(0,context.Sellers.Count());
            cashDesk = new CashDesk(1, context.Sellers.ToList().ElementAt(item),context);
            cashDesk.IsModel = false;
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

        private void Main_Load(object sender, EventArgs e)
        {
            Task.Run(() => listBoxProducts.Invoke((Action)delegate
            {
                listBoxProducts.Items.AddRange(context.Products.ToArray());
            }));
        }

        private  void UpDateListBox()
        {
            listBoxCart.Items.Clear();
            listBoxCart.Items.AddRange(cart.GetAll().ToArray());
            labelSum.Text = cart.SumCart.ToString();
        }

        private void listBoxProducts_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem != null)
            {
                if (listBoxProducts.SelectedItems[0] is Product product)
                {
                    cart.Add(product);
                    UpDateListBox();
                }
                buttonSell.Enabled = cart.SumCart != 0;
            }
        }

        private void listBoxCart_DoubleClick(object sender, EventArgs e)
        {
        //    if (listBoxProducts.SelectedItems[0] is Product product)
        //    {
        //        cart.Delete(product);
        //        UpDateListBox();
        //    }
        //    buttonSell.Enabled = cart.SumCart != 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new LoginForm();
            if(form.ShowDialog()==DialogResult.OK)
            {
                customer = form.Customer;
                cart.Customer=customer; 
                linkLabel1.Text = $"Здравствуй, {customer.Name}!";
            }
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
           if(customer==null)
           {
                MessageBox.Show("Авторизуйтесь пожалуйста!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           else
           {
                cashDesk.Enqueue(cart);
                var price = cashDesk.Dequeue();
                listBoxCart.Items.Clear();
                cart = new Cart(customer);
                labelSum.Text = "0";
                MessageBox.Show($"Покупка выполнена!\nСумма покупки: {price}\nПокупатель: {customer.Name}","Справка",MessageBoxButtons.OK,MessageBoxIcon.Information);
           }
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Авторизация пользователя";
        }
    }
}
