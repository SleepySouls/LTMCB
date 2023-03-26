using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Bai_5 : Form
    {
        public Bai_5()
        {
            InitializeComponent();
        }

        private void xoa()
        {
            tb_nhap_A.Text = "";
            tb_nhap_B.Text = "";
            tb_A_factorial.Text = "";
            tb_B_factorial.Text = "";
            tb_sum_A.Text = "";
            tb_sum_B.Text = "";
            tb_a_mu_b.Text = "";
        }

        private void bt_tinh_Click(object sender, EventArgs e)
        {
            string n1, n2;
            int a, b, i, factorialA, factorialB, sA, sB, sAB, luythua;
            factorialA = 1;
            factorialB = 1;
            sA = 0;
            sB = 0;
            sAB = 0;
            luythua = 1;
            n1 = tb_nhap_A.Text;
            n2 = tb_nhap_B.Text;
            if (int.TryParse(n1, out a) == false)
                MessageBox.Show("Vui lòng nhập số nguyên!");
            if (int.TryParse(n2, out b) == false)
                MessageBox.Show("Vui lòng nhập số nguyên!");
            
            //Tính giai thừa của A
            for (i = 1; i <= a; i++)
                factorialA = factorialA * i;
            tb_A_factorial.Text = "A!= " + factorialA.ToString();
            //Tính giai thừa của B
            for (i = 1; i<= b; i++)
                factorialB = factorialB * i;
            tb_B_factorial.Text = "B!= " + factorialB.ToString();
            //Tính tổng 1+2+3+4+...+A
            for (i = 1; i<= a; i++)
                sA = sA + i;
            tb_sum_A.Text = "S1 = 1 + 2 + 3 + 4 +...+ A =  " + sA.ToString();
            //Tính tổng 1+2+3+4+...+B
            for (i = 1; i<= b; i++)
                sB = sB + i;
            tb_sum_B.Text = "S2 = 1 + 2 + 3 + 4 +...+ B = " + sB.ToString();
            //Tính tổng A^1 + A^2 + A^3 + A^4 + ... + A^B
            for (i = 1; i <= b; i++)
            {
                luythua = luythua * a;
                sAB = sAB + luythua;
            }    
            tb_a_mu_b.Text = "S3 = A^1 + A^2 + A^3 + A^4 + ... + A^B = " + sAB.ToString();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tb_A_factorial_TextChanged(object sender, EventArgs e)
        {
            tb_A_factorial.BackColor = this.BackColor;
        }

        private void tb_B_factorial_TextChanged(object sender, EventArgs e)
        {
            tb_B_factorial.BackColor = this.BackColor;
        }

        private void tb_sum_A_TextChanged(object sender, EventArgs e)
        {
            tb_sum_A.BackColor = this.BackColor;
        }

        private void tb_sum_B_TextChanged(object sender, EventArgs e)
        {
            tb_sum_B.BackColor = this.BackColor;
        }

        private void tb_a_mu_b_TextChanged(object sender, EventArgs e)
        {
            tb_a_mu_b.BackColor = this.BackColor;
        }
    }
}
