using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace subway
{
    public partial class HomePage : Form
    {
        public static string filename;
        public static string jang;
        public System.Windows.Forms.TextBox TextBox1 { get { return textBox1; } }

        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form11 showForm11 = new Form11();
            showForm11.StartPosition = FormStartPosition.Manual;
            showForm11.Location = new Point(this.Location.X, this.Location.Y);
            showForm11.Show();

            filename = textBox1.Text;
            jang = "매장";

            showForm11.LoadTextFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form11 showForm11 = new Form11();
            showForm11.StartPosition = FormStartPosition.Manual;
            showForm11.Location = new Point(this.Location.X, this.Location.Y);
            showForm11.Show();

            filename = TextBox1.Text;
            jang = "포장";

            showForm11.LoadTextFile();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
