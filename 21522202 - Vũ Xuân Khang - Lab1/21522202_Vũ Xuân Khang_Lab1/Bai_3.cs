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
    public partial class Bai_3 : Form
    {
        public Bai_3()
        {
            InitializeComponent();
        }

        private void xoa()
        {
            tb_nhap.Text = "";
            tb_kq.Text = "";
        }

        private void bt_doc_Click(object sender, EventArgs e)
        {
            int s1;
            string s2;
            s1 = Int32.Parse(tb_nhap.Text);
            if ((s1 < 0) || (s1 > 9))
                MessageBox.Show("Vui lòng nhập só nguyên từ 0 đến 9");
            else
                switch(s1)
                {
                    case 0:
                        s2 = "Không";
                        tb_kq.Text = s2.ToString();
                        break;
                    case 1:
                        s2 = "Một";
                        tb_kq.Text = s2.ToString();
                        break;
                    case 2:
                        s2 = "Hai";
                        tb_kq.Text = s2.ToString();
                        break;
                    case 3:
                        s2 = "Ba";
                        tb_kq.Text = s2.ToString();
                        break;
                    case 4:
                        s2 = "Bốn";
                        tb_kq.Text = s2.ToString();
                        break;
                    case 5:
                        s2 = "Năm";
                        tb_kq.Text = s2.ToString();
                        break;
                    case 6:
                        s2 = "Sáu";
                        tb_kq.Text = s2.ToString();
                        break;
                    case 7:
                        s2 = "Bảy";
                        tb_kq.Text = s2.ToString();
                        break;
                    case 8:
                        s2 = "Tám";
                        tb_kq.Text = s2.ToString();
                        break;
                    case 9:
                        s2 = "Chín";
                        tb_kq.Text = s2.ToString();
                        break;
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
