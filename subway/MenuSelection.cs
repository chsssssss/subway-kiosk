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
    public partial class MenuSelection : Form
    {
        public static string menu;
        public MenuSelection()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /* form11 실행 (이전)*/
        private void button12_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form11 showForm11 = new Form11();
            showForm11.StartPosition = FormStartPosition.Manual;
            showForm11.Location = new Point(this.Location.X, this.Location.Y);
            showForm11.Show();
        }

        /* form2 실행 (다음)*/
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BreadSelection showForm2 = new BreadSelection();
            showForm2.StartPosition = FormStartPosition.Manual;
            showForm2.Location = new Point(this.Location.X, this.Location.Y);
            showForm2.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu = "K 바비큐";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu = "치킨 슬라이스";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu = "이탈리안 비엠티";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            menu = "써브웨이 클럽";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            menu = "로스트 치킨";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            menu = "에그마요";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            menu = "폴드포크 바비큐";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            menu = "쉬림프";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            menu = "스테이크 치즈";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            menu = "스파이시 이탈리안";
        }
    }
}
