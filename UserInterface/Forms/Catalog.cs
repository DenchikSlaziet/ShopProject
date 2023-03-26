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

namespace UserInterface.Forms
{
    public partial class Catalog<T> : Form where T : class
    {
        public Catalog(DbSet<T> set)
        {
            InitializeComponent();
            //Рефачил было dataGridView.DataSource = set.Local.ToBindingList();
            dataGridView.DataSource = set.ToList();
            //
        }
    }
}
