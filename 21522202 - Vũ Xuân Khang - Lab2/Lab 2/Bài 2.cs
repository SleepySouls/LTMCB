using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Bai_2 : Form
    {
        public Bai_2()
        {
            InitializeComponent();
            tb_charcount.ReadOnly = true;
            tb_filename.ReadOnly = true;
            tb_linecount.ReadOnly = true;
            tb_path.ReadOnly = true;
            tb_size.ReadOnly = true;
            tb_wordcount.ReadOnly = true;
            rtb_content.ReadOnly = true;
        }

        private void bt_readfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            rtb_content.Text = content;
            int length = content.Length;
            tb_size.Text = length.ToString() + " bytes";
            string name = ofd.SafeFileName;
            tb_filename.Text = name;
            string path = System.IO.Path.GetDirectoryName(ofd.FileName);
            tb_path.Text = path;
            int i = 0;
            int wordCount = 0;
            int charCount = 0;
            while (i <= length - 1)
            {
                charCount++;
                if (Char.IsWhiteSpace(content, i) == true)
                    wordCount++;
                i++;
            }

            tb_wordcount.Text = wordCount.ToString();
            tb_charcount.Text = charCount.ToString();
            fs.Close();
            var lineCount = File.ReadLines(ofd.FileName).Count();
            tb_linecount.Text = lineCount.ToString() + "\n";
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
