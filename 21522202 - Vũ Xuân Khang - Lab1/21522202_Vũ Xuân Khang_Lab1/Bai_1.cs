using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bai_1 : Form
    {
        public Bai_1()
        {
            InitializeComponent();
        }

        private void tb_s1_TextChanged(object sender, EventArgs e)
        {
            string s1;
            int s3;
            s1 = tb_s1.Text;
            if (int.TryParse(s1, out s3) == false)
                MessageBox.Show("Số thứ nhất không phải là số nguyên, vui lòng nhập lại!");
        }

        private void tb_s2_TextChanged(object sender, EventArgs e)
        {
            string s2;
            int s4;
            s2 = tb_s1.Text;
            if (int.TryParse(s2, out s4) == false)
                MessageBox.Show("Số thứ hai không phải là số nguyên, vui lòng nhập lại!");
        }

        private void bt_calculate_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            num1 = Int32.Parse(tb_s1.Text.Trim());
            num2 = Int32.Parse(tb_s2.Text.Trim());
            sum = num1 + num2;
            tb_kq.Text = sum.ToString();
        }
    }
}
