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

namespace Lab_2
{
    public partial class Bai_1 : Form
    {
        public Bai_1()
        {
            InitializeComponent();
            rtb_content.ReadOnly = true;
        }

        private void bt_readfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog odf = new OpenFileDialog();
            odf.ShowDialog();
            StreamReader sr = new StreamReader(odf.FileName);
            string content = sr.ReadToEnd();
            rtb_content.Text = content;
        }

        private void bt_writefile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtb_content.Text))
            {
                MessageBox.Show("Please read a file before write it!");
                return;
            }
            else
            {
                OpenFileDialog odf = new OpenFileDialog();
                odf.ShowDialog();
                StreamWriter sw = new StreamWriter(odf.FileName);
                sw.WriteLine(rtb_content.Text.ToUpper());
                sw.Close();
                MessageBox.Show("Your file is done !");
            }
        }
    }
}
