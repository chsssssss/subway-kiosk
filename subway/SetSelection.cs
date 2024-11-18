using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace subway
{
    public partial class SetSelection : Form
    {
        public static string cookie;
        public static string drink;
        public static string selectedItems = string.Empty;
        private Button selectedSingleItemButton;
        private List<Button> selectedSetItems = new List<Button>();
        public static string[] fileContents;

        public SetSelection()
        {
            InitializeComponent();
        }

        /* form6 실행 (이전)*/
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddToppingSelection form6 = new AddToppingSelection();
            form6.StartPosition = FormStartPosition.Manual;
            form6.Location = new Point(this.Location.X, this.Location.Y);
            form6.ShowDialog();
        }

        // form13 실행 (다음)
        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("메뉴 선택이 완료되었습니다.");
            this.Visible = false;
            OrderCheck showForm13 = new OrderCheck();
            showForm13.StartPosition = FormStartPosition.Manual;
            showForm13.Location = new Point(this.Location.X, this.Location.Y);
            showForm13.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            cookie = "더블초코칩";
            Button button = (Button)sender;
            UpdateSelectedSingleItem(button);
            UpdateLabel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cookie = "라즈베리 치즈케익";
            Button button = (Button)sender;
            UpdateSelectedSingleItem(button);
            UpdateLabel();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cookie = "오트밀 레이즌";
            Button button = (Button)sender;
            UpdateSelectedSingleItem(button);
            UpdateLabel();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cookie = "초코칩";
            Button button = (Button)sender;
            UpdateSelectedSingleItem(button);
            UpdateLabel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cookie = "화이트 초코 마카다미아";
            Button button = (Button)sender;
            UpdateSelectedSingleItem(button);
            UpdateLabel();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            drink = "탄산음료";
            Button button = (Button)sender;
            UpdateSelectedSingleItem(button);
            UpdateLabel();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            drink = "커피";
            Button button = (Button)sender;
            UpdateSelectedSingleItem(button);
            UpdateLabel();
        }

        private void 단품_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UpdateSelectedSingleItem(button);
            UpdateLabel();
        }

        private void UpdateSelectedSingleItem(Button button)
        {
            selectedSingleItemButton = button;
            selectedSetItems.Clear();
        }

        private void UpdateSelectedSetItem(Button button)
        {
            if (selectedSetItems.Contains(button))
            {
                selectedSetItems.Remove(button);
            }
            else
            {
                selectedSetItems.Add(button);
            }

            selectedSingleItemButton = null;
        }

        private void UpdateLabel()
        {
            StringBuilder builder = new StringBuilder();

            if (selectedSingleItemButton != null)
            {
                builder.AppendLine(selectedSingleItemButton.Text);
            }
            else
            {
                foreach (Button button in selectedSetItems)
                {
                    builder.AppendLine(button.Text);
                }
            }

            selectedItems = builder.ToString().TrimEnd();
            label2.Text = selectedItems.Replace(Environment.NewLine, ", ");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
