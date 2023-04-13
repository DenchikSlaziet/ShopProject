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

namespace UserInterface.Forms
{
    public partial class ModelForm : Form
    {
        private ShopComputerModel model = new ShopComputerModel();

        public ModelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var cashBoxes = new List<CashBoxView>();

            for (int i = 0; i < model.CashDesks.Count; i++)
            {
                var box = new CashBoxView(model.CashDesks[i], i, 10, 55 * (i+1));
                cashBoxes.Add(box);
                Controls.Add(box.CashDeskName);
                Controls.Add(box.Price);
                Controls.Add(box.QueueLength);
                Controls.Add(box.LeaveCustomersCount);
            }

            model.Start();
            button1.Enabled = false;
        }

        private void ModelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.Stop();
        }

        private void ModelForm_Load(object sender, EventArgs e)
        {
            numericUpDownSpeedCustomer.Value = model.CustomerSpeed;
            numericUpDownSpeedSeller.Value = model.CashDeskSpeed;
        }

        private void numericUpDownSpeedSeller_ValueChanged(object sender, EventArgs e)
        {
            model.CashDeskSpeed = (int)numericUpDownSpeedSeller.Value;
        }

        private void numericUpDownSpeedCustomer_ValueChanged(object sender, EventArgs e)
        {
            model.CustomerSpeed = (int)numericUpDownSpeedCustomer.Value;
        }
    }
}
