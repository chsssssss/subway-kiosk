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
using Button = System.Windows.Forms.Button;

namespace subway
{
    public partial class AddToppingSelection : Form
    {
        public static string add;
        private List<Button> selectedButtons = new List<Button>();

        public AddToppingSelection()
        {
            InitializeComponent();
        }

        private void AppendToFile(string fileName, List<string> content)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                if (content != null && content.Count > 0)
                {
                    writer.WriteLine(string.Join(", ", content));
                }
                else
                {
                    writer.WriteLine(); // 빈 줄 입력
                }
            }
        }


        /* form5 실행 (이전)*/
        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            SauceSelection showForm5 = new SauceSelection();
            showForm5.StartPosition = FormStartPosition.Manual;
            showForm5.Location = new Point(this.Location.X, this.Location.Y);
            showForm5.Show();
        }

        /* form7 실행 (다음)*/
        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("메뉴 선택이 완료되었습니다.");
            this.Visible = false;
            Form showForm7 = new SetSelection();
            showForm7.StartPosition = FormStartPosition.Manual;
            showForm7.Location = new Point(this.Location.X, this.Location.Y);
            showForm7.Show();

            FileInfo fi = new FileInfo(HomePage.filename + ".txt");

            if (fi.Exists)
            {
                using (StreamWriter writer = new StreamWriter(HomePage.filename + ".txt", true))
                {
                    writer.WriteLine(MenuSelection.menu);
                    writer.WriteLine(BreadSelection.bread);
                    writer.WriteLine(CheeseSelection.cheese);
                    writer.WriteLine(VegetableSelection.vege);
                    writer.WriteLine(SauceSelection.sauce);
                    writer.WriteLine(AddToppingSelection.add);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(HomePage.filename + ".txt"))
                {
                    writer.WriteLine(MenuSelection.menu);
                    writer.WriteLine(BreadSelection.bread);
                    writer.WriteLine(CheeseSelection.cheese);
                    writer.WriteLine(VegetableSelection.vege);
                    writer.WriteLine(SauceSelection.sauce);
                    writer.WriteLine(AddToppingSelection.add);

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateSelectedButtons(button);
            UpdateLabel();
        }

        private void Form6_Load(object sender, EventArgs e)
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
            add = string.Join(", ", selectedButtons.Select(btn => btn.Name));
            label1.Text = add;
        }
    }
}
