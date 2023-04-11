using CRMBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public class CashBoxView
    {
        CashDesk cashDesk;

        public Label CashDeskName { get; set; } = new Label();
        public Label LeaveCustomersCount { get; set; } = new Label();
        public NumericUpDown Price { get; set; } = new NumericUpDown();
        public ProgressBar QueueLength { get; set; } = new ProgressBar();

        public CashBoxView(CashDesk cashDesk,int number,int x , int y)
        {
            this.cashDesk = cashDesk;

            CashDeskName.AutoSize = true;
            CashDeskName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            CashDeskName.Location = new System.Drawing.Point(x, y);
            CashDeskName.Name = this.cashDesk.ToString();
            CashDeskName.Size = new System.Drawing.Size(108, 22);
            CashDeskName.TabIndex = number;
            CashDeskName.Text = $"Касса№{number}:";

            Price.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Price.Location = new System.Drawing.Point(x+110, y-5);
            Price.Name = "numericUpDown"+number;
            Price.Size = new System.Drawing.Size(165, 31);
            Price.TabIndex = number;
            Price.Maximum = 10000000000000000000;

            QueueLength.Location = new System.Drawing.Point(x+300, y);
            QueueLength.Maximum = cashDesk.MaxQueueLength;
            QueueLength.Name = "progressBar"+number;
            QueueLength.Size = new System.Drawing.Size(100, 23);
            QueueLength.TabIndex = number;
            QueueLength.Value = 0;

            LeaveCustomersCount.AutoSize = true;
            LeaveCustomersCount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            LeaveCustomersCount.Location = new System.Drawing.Point(x+400, y);
            LeaveCustomersCount.Name = "label" + number;
            LeaveCustomersCount.Size = new System.Drawing.Size(108, 22);
            LeaveCustomersCount.TabIndex = number;
            LeaveCustomersCount.Text = "";

            cashDesk.CheckClosed += CashDesk_CheckClosed;
        }

        private void CashDesk_CheckClosed(object sender, Check e)
        {
            Price.Invoke((Action) delegate 
            {
                Price.Value += e.Price;
                if (cashDesk.Count > QueueLength.Maximum)
                {
                    QueueLength.Value = 1;
                }
                else
                {
                    QueueLength.Value = cashDesk.Count;
                }
                LeaveCustomersCount.Text = cashDesk.ExitCustomer.ToString();
            });
        }
    }
}
