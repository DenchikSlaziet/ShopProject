using CRMBL.Model;
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
            context = new MyDbContext();
        }

        private void CheckGrid_Load(object sender, EventArgs e)
        {
            string query = "SELECT Customers.Name, Customers.NumberCard, Sellers.Name , Sellers.Surname , Sellers.UniqueNumber , Checks.CreatedData FROM Customers,Sellers,Checks WHERE Customers.CustomerId = Checks.CustomerId AND Sellers.SellerId = Checks.SellerId;";
            connection.Open();
            command=new SqlCommand(query, connection);

            var reader = command.ExecuteReader();
            var list = new List<string[]>();

            while (reader.Read())
            {
                list.Add(new string[6]);

                list[list.Count - 1][0] = reader[0].ToString();
                list[list.Count - 1][1] = reader[1].ToString();
                list[list.Count - 1][2] = reader[2].ToString();
                list[list.Count - 1][3] = reader[3].ToString();
                list[list.Count - 1][4] = reader[4].ToString();
                list[list.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();
            connection.Close();

            foreach (var item in list)
            {
                dataGridView.Rows.Add(item);
            }
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            toolStripStatusLabelCount.Text = $"Кол-во: {context.Checks.Count()}";
            toolStripStatusLabelPrice.Text = $"Общая выручка: {context.Checks.Sum(x => x.Price)} руб.";
        }
    }
}
