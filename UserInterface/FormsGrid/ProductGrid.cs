using CRMBL.Model;
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

namespace UserInterface.FormsGrid
{
    public partial class ProductGrid : Form
    {
        private MyDbContext context;
        public ProductGrid()
        {
            InitializeComponent();
            context=new MyDbContext();
            dataGridView.DataSource = context.Products.ToList();
        }
    }
}
