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
using Button = System.Windows.Forms.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace subway
{
    public partial class VegetableSelection : Form
    {
        public static string vege;
        private List<Button> selectedButtons = new List<Button>();

        public VegetableSelection()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        /* form3 실행 (이전)*/
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CheeseSelection showform3 = new CheeseSelection();
            showform3.StartPosition = FormStartPosition.Manual;
            showform3.Location = new Point(this.Location.X, this.Location.Y);
            showform3.Show();
        }

        /* form5 실행 (다음)*/
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SauceSelection showform5 = new SauceSelection();
            showform5.StartPosition = FormStartPosition.Manual;
            showform5.Location = new Point(this.Location.X, this.Location.Y);
            showform5.Show();
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
            vege = string.Join(", ", selectedButtons.Select(btn => btn.Name));
            label1.Text = vege;
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

        private void button5_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateSelectedButtons(button);
            UpdateLabel();
        }     
    }
}
