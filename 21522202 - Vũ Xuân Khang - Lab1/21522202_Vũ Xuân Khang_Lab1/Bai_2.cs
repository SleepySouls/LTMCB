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
    public partial class Bai_2 : Form
    {
        public Bai_2()
        {
            InitializeComponent();
        }

        private void xoa()
        {
            tb_s1.Text = "";
            tb_s2.Text = "";
            tb_s3.Text = "";
            tb_sln.Text = "";
            tb_snn.Text = "";
        }
        private void bt_tim_Click(object sender, EventArgs e)
        {
            string s1, s2, s3;
            double num1, num2, num3;
            s1 = tb_s1.Text;
            s2 = tb_s2.Text;
            s3 = tb_s3.Text;
            if (double.TryParse(s1, out num1) == false)
                MessageBox.Show("Vui lòng nhập số!");
            if (double.TryParse(s2, out num2)==false)
                MessageBox.Show("Vui lòng nhập số!");
            if (Double.TryParse(s3, out num3)==false)
                MessageBox.Show("Vui lòng nhập số!");

            if ((num1 < num2) && (num1 < num3))
            {
                tb_snn.Text = num1.ToString();
                if (num2 > num3)
                    tb_sln.Text = num2.ToString();
                else
                    tb_sln.Text = num3.ToString();
            }


            if ((num2 < num1) && (num2 < num3))
            {
                tb_snn.Text = num2.ToString();
                if (num3 > num1)
                    tb_sln.Text = num3.ToString();
                else
                    tb_sln.Text = num1.ToString();
            }


            if ((num3 < num1) && (num3 < num2))
            {
                tb_snn.Text = num3.ToString();
                if (num1 > num2)
                    tb_sln.Text = num1.ToString();
                else
                    tb_sln.Text= num2.ToString();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
