using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace subway
{
    public partial class SauceSelection : Form
    {
        public static string sauce;
        private List<Button> selectedButtons = new List<Button>();

        public SauceSelection()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /* form4 실행 (이전)*/
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VegetableSelection showform4 = new VegetableSelection();
            showform4.StartPosition = FormStartPosition.Manual;
            showform4.Location = new Point(this.Location.X, this.Location.Y);
            showform4.Show();
        }

        /* form6 실행 (다음)*/
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddToppingSelection showform6 = new AddToppingSelection();
            showform6.StartPosition = FormStartPosition.Manual;
            showform6.Location = new Point(this.Location.X, this.Location.Y);
            showform6.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void UpdateSelectedButtons(Button button)
        {
            if (selectedButtons.Contains(button))
            {
                selectedButtons.Remove(button);
            }
            else
            {
                selectedButtons.Add(button);
            }
        }

        private void UpdateLabel()
        {
            sauce = string.Join(", ", selectedButtons.Select(btn => btn.Name));
            label1.Text = sauce;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateSelectedButtons(button);
            UpdateLabel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateSelectedButtons(button);
            UpdateLabel();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateSelectedButtons(button);
            UpdateLabel();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateSelectedButtons(button);
            UpdateLabel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateSelectedButtons(button);
            UpdateLabel();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateSelectedButtons(button);
            UpdateLabel();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateSelectedButtons(button);
            UpdateLabel();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateSelectedButtons(button);
            UpdateLabel();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateSelectedButtons(button);
            UpdateLabel();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateSelectedButtons(button);
            UpdateLabel();
        }
    }
}
