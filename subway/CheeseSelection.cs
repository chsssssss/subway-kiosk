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
    public partial class CheeseSelection : Form
    {
        public static string cheese;
        private List<Button> selectedButtons = new List<Button>();

        public CheeseSelection()
        {
            InitializeComponent();
        }

        /* form2 실행 (이전)*/
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BreadSelection showForm2 = new BreadSelection();
            showForm2.StartPosition = FormStartPosition.Manual;
            showForm2.Location = new Point(this.Location.X, this.Location.Y);
            showForm2.Show();
        }

        /* form4 실행 (다음)*/
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            VegetableSelection showForm4 = new VegetableSelection();
            showForm4.StartPosition = FormStartPosition.Manual;
            showForm4.Location = new Point(this.Location.X, this.Location.Y);
            showForm4.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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

        private void button8_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateSelectedButtons(button);
            UpdateLabel();
        }

        private void UpdateSelectedButtons(Button button)
        {
            if (button == 선택안함)
            {
                // button7이 선택된 경우 다른 버튼들의 선택을 해제
                foreach (Button otherButton in new[] { 모차렐라치즈, 슈레드치즈, 아메리칸치즈 })
                {
                    if (selectedButtons.Contains(otherButton))
                    {
                        selectedButtons.Remove(otherButton);
                        otherButton.BackColor = SystemColors.Control;
                    }
                }
            }
            else if (button == 모차렐라치즈추가 || button == 슈레드치즈추가 || button == 아메리칸치즈추가)
            {
                if (selectedButtons.Contains(button))
                {
                    selectedButtons.Remove(button);
                    button.BackColor = SystemColors.Control;
                }
                else
                {
                    selectedButtons.Add(button);
                    button.BackColor = Color.LightBlue;
                }
            }
            else
            {
                // 다른 버튼들은 중복 선택 불가능
                foreach (Button otherButton in new[] { 모차렐라치즈추가, 슈레드치즈추가, 아메리칸치즈추가 })
                {
                    if (selectedButtons.Contains(otherButton))
                    {
                        selectedButtons.Remove(otherButton);
                        otherButton.BackColor = SystemColors.Control;
                    }
                }

                if (selectedButtons.Contains(button))
                {
                    selectedButtons.Remove(button);
                    button.BackColor = SystemColors.Control;
                }
                else
                {
                    selectedButtons.Add(button);
                    button.BackColor = Color.LightBlue;
                }
            }
        }

        private void UpdateLabel()
        {
            cheese = string.Join(", ", selectedButtons.Select(btn => btn.Name));
            label1.Text = cheese;
        }
    }

}
