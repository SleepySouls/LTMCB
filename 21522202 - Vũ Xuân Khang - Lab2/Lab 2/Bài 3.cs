using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class bai_3 : Form
    {
        public bai_3()
        {
            InitializeComponent();
        }
        private void bt_readfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            StreamReader sr = new StreamReader(ofd.FileName);
            string content = sr.ReadToEnd();
            rtb_content.Text = content;
        }
        private void Calculate(string calculate)
        {
            string[] calculates = calculate.Split();
            int size = calculates.Length;
            MessageBox.Show(size.ToString());
        }

        private void bt_writefile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            StreamWriter sw = new StreamWriter(ofd.FileName);
            string[] cal = rtb_content.Text.Split(new[] { "\n" }, StringSplitOptions.None);
            Calculate(cal[0]);
            sw.WriteLine(cal[0] + " = 10");
            sw.Close();
        }
    }
}
