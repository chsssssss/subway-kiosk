using subway;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace subway
{
    public partial class Form11 : Form
    {
        //private Form10 form10;
        
        public static string[] rowContents;
        public Form11()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = HomePage.filename;
            string filePath = filename + ".txt";
            MessageBox.Show(filePath);
            if (File.Exists(filePath))
            {
                // 파일이 존재하는 경우
                // 주문 히스토리 선택하기

                // 주문확인창으로 넘어가기
                this.Visible = false;
                SetSelection showform7 = new SetSelection();
                showform7.StartPosition = FormStartPosition.Manual;
                showform7.Location = new Point(this.Location.X, this.Location.Y);
                showform7.Show();
            }
            
            else
            {
                MessageBox.Show("이용한 내역이 없습니다. 새로운 주문을 시작합니다.");
                // form1로 이동
                this.Visible = false;
                MenuSelection showform1 = new MenuSelection();
                showform1.StartPosition = FormStartPosition.Manual;
                showform1.Location = new Point(this.Location.X, this.Location.Y);
                showform1.Show();
            }

        }

        private void Form11_Load(object sender, EventArgs e)
        {
  
            LoadTextFile();

        }

        public void LoadTextFile()
        {
            string filename = HomePage.filename;
            listView1.Items.Clear();
            listView1.Columns.Clear();

            listView1.View = View.Details;

            listView1.Columns.Add("메뉴", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("빵", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("치즈", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("야채", 180, HorizontalAlignment.Center);
            listView1.Columns.Add("소스", 140, HorizontalAlignment.Center);
            listView1.Columns.Add("추가선택", 55, HorizontalAlignment.Center);


            if (File.Exists(filename + ".txt"))
            {
                using (StreamReader reader = new StreamReader(filename + ".txt"))
                {

                    List<string> lines = new List<string>();
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }

                    int linesPerGroup = 6;
                    int totalLines = lines.Count;
                    int numGroups = (int)Math.Ceiling((double)totalLines / linesPerGroup);

                    for (int i = 0; i < numGroups; i++)
                    {
                        int startIndex = i * linesPerGroup;
                        int endIndex = Math.Min(startIndex + linesPerGroup, totalLines);
                        List<string> groupLines = lines.GetRange(startIndex, endIndex - startIndex);

                        ListViewItem newItem = new ListViewItem(groupLines.ToArray());
                        listView1.Items.Add(newItem);
                    }
                }
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Form1로 이동
            this.Visible = false;
            MenuSelection showform1 = new MenuSelection();
            showform1.StartPosition = FormStartPosition.Manual;
            showform1.Location = new Point(this.Location.X, this.Location.Y);
            showform1.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                rowContents = new string[selectedItem.SubItems.Count];
                
                for (int i = 0; i < selectedItem.SubItems.Count; i++)
                {
                    rowContents[i] = selectedItem.SubItems[i].Text;
                }
                MessageBox.Show("선택완료");

                // rowContents 배열에 선택한 row의 내용이 저장됨
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Form10로 이동
            this.Visible = false;
            HomePage showform10 = new HomePage();
            showform10.StartPosition = FormStartPosition.Manual;
            showform10.Location = new Point(this.Location.X, this.Location.Y);
            showform10.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
