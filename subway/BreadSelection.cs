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

    public partial class BreadSelection : Form
    {
        public static string bread;
        public BreadSelection()
        {
            InitializeComponent();
        }


        /* form2 실행 (이전)*/
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form11 showform1 = new Form11();
            showform1.StartPosition = FormStartPosition.Manual;
            showform1.Location = new Point(this.Location.X, this.Location.Y);
            showform1.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        /* form3 실행 (다음)*/
        private void button9_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CheeseSelection showform3 = new CheeseSelection();
            showform3.StartPosition = FormStartPosition.Manual;
            showform3.Location = new Point(this.Location.X, this.Location.Y);
            showform3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bread = "화이트";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bread = "파마산 오레가노";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bread = "위트";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bread = "허니오트";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bread = "하티";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bread = "플랫브레드";
        }
    }
}
