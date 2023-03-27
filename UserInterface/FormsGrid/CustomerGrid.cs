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

namespace UserInterface.FormsGrid
{
    public partial class CustomerGrid : Form
    {
        private MyDbContext context;
        public CustomerGrid()
        {
            InitializeComponent();
            context = new MyDbContext();
            dataGridView.DataSource=context.Customers.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource= context.Customers.ToList();
        }
    }
}
