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
    public partial class PaymentProcessing : Form
    {
        public PaymentProcessing()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SuccessOrder showForm12 = new SuccessOrder();
            showForm12.StartPosition = FormStartPosition.Manual;
            showForm12.Location = new Point(this.Location.X, this.Location.Y);
            showForm12.Show();
        }

        private void PaymentProcessing_Load(object sender, EventArgs e)
        {

        }
    }
}
