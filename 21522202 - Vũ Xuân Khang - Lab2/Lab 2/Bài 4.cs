using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Bai_4 : Form
    {
        public Bai_4()
        {
            InitializeComponent();
            tb_read_average.ReadOnly = true;
            tb_read_course1.ReadOnly = true;
            tb_read_course2.ReadOnly = true;
            tb_read_course3.ReadOnly = true;
            tb_read_id.ReadOnly = true;
            tb_read_phone.ReadOnly = true;
            tb_read_name.ReadOnly = true;
            rtb_content.ReadOnly = true;
            CheckType();
        }
        string[] Students;
        private void bt_writefile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtb_content.Text))
            {
                MessageBox.Show("Please add student's information before write!");
                return;
            }
            else
            {
                string[] writeInfo = rtb_content.Text.Split('\n');
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fileName = File.Create(ofd.FileName);
                bf.Serialize(fileName, writeInfo);
                MessageBox.Show("Student's information has done!");
                rtb_content.Clear();
                fileName.Close();
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_write_course1.Text) || string.IsNullOrEmpty(tb_write_course2.Text) || string.IsNullOrEmpty(tb_write_course3.Text) || string.IsNullOrEmpty(tb_write_id.Text) || string.IsNullOrEmpty(tb_write_name.Text) || string.IsNullOrEmpty(tb_write_phone.Text))
            {
                MessageBox.Show("Please fill all the information of student before add!");
                return;
            }
            else
            {
                rtb_content.Text += tb_write_name.Text + '\n';
                rtb_content.Text += tb_write_id.Text + '\n';
                rtb_content.Text += tb_write_phone.Text + '\n';
                rtb_content.Text += tb_write_course1.Text + '\n';
                rtb_content.Text += tb_write_course2.Text + '\n';
                rtb_content.Text += tb_write_course3.Text + '\n';
                rtb_content.Text += "\n";
            }
 
            tb_write_name.Clear();
            tb_write_phone.Clear();
            tb_write_course1.Clear();
            tb_write_course2.Clear();
            tb_write_course3.Clear();
            tb_write_id.Clear();
        }
        private void readStudentInfo(string info)
        {
            string[] read = info.Split('\n');
            tb_read_name.Text = read[0];
            tb_read_id.Text = read[1];
            tb_read_phone.Text = read[2];
            tb_read_course1.Text = read[3];
            tb_read_course2.Text = read[4];
            tb_read_course3.Text = read[5];
            float course1_score = float.Parse(read[3]);
            float course2_score = float.Parse(read[4]);
            float course3_score = float.Parse(read[5]);
            tb_read_average.Text = ((course1_score + course2_score + course3_score) / 3).ToString(); 
        }
        private void bt_readfile_Click(object sender, EventArgs e)
        {
            string[] readInfo = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenRead(ofd.FileName);
            readInfo = (string[])bf.Deserialize(fs);
            int i = 0;
            while (i < readInfo.Length) 
            {
                rtb_content.Text += readInfo[i] + '\n';
                i++;
            }
            
            Students = rtb_content.Text.Split(new[] { "\n\n" }, StringSplitOptions.None);
            readStudentInfo(Students[0]);
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            int page = int.Parse(lb_page.Text) + 1;
            if (page == Students.Length)
                return;
            else
                lb_page.Text = page.ToString();
            readStudentInfo(Students[page - 1]);
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            int page = int.Parse(lb_page.Text) - 1;
            if (page == 0)
                return;
            else
                lb_page.Text = page.ToString();
            readStudentInfo(Students[page - 1]);
        }

        private void  CheckType()
        {
            int id;
            float course1, course2, course3;
            bool IsStringContainNumber = tb_write_name.Text.Any(char.IsDigit);
            if (IsStringContainNumber)
            {
                MessageBox.Show("Student's name contain number, please fill your right name!");
                return;
            }
            if (int.TryParse(tb_write_id.Text, out id) == false || tb_write_id.Text.Any(char.IsLetter) == true || tb_write_id.Text.Length >= 9)
            {
                MessageBox.Show("Student's ID should contain only integer number or should be 8 numbers, please try again!");
                return;
            }
            if (tb_write_phone.Text.Any(char.IsDigit) == false || tb_write_phone.Text.Length >= 11)
            {
                MessageBox.Show("Student's phone number should not contain character or should be 10 numbers, please try again!");
                return;
            }
            if (float.TryParse(tb_write_course1.Text, out course1) == false)
            {
                MessageBox.Show("Student's score of course 1 should be a number, please try again");
                return;
            }
            if (float.TryParse(tb_write_course2.Text, out course2) == false)
            {
                MessageBox.Show("Student's score of course 2 should be a number, please try again");
                return;
            }
            if (float.TryParse(tb_write_course3.Text, out course3) == false)
            {
                MessageBox.Show("Student's score of course 3 should be a number, please try again");
                return;
            }

        }
    }
}
