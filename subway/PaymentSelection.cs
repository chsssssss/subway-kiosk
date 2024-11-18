using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subway
{
    public partial class PaymentSelection : Form
    {
        public PaymentSelection()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PaymentProcessing showForm9 = new PaymentProcessing();
            showForm9.StartPosition = FormStartPosition.Manual;
            showForm9.Location = new Point(this.Location.X, this.Location.Y);
            showForm9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PaymentProcessing showForm9 = new PaymentProcessing();
            showForm9.StartPosition = FormStartPosition.Manual;
            showForm9.Location = new Point(this.Location.X, this.Location.Y);
            showForm9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PaymentProcessing showForm9 = new PaymentProcessing();
            showForm9.StartPosition = FormStartPosition.Manual;
            showForm9.Location = new Point(this.Location.X, this.Location.Y);
            showForm9.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OrderCheck showForm13 = new OrderCheck();
            showForm13.StartPosition = FormStartPosition.Manual;
            showForm13.Location = new Point(this.Location.X, this.Location.Y);
            showForm13.Show();
        }

        private void PaymentSelection_Load(object sender, EventArgs e)
        {

        }
    }
}
