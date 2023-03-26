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
    public partial class Bai_4 : Form
    {
        public Bai_4()
        {
            InitializeComponent();
        }

        private void bt_chuyendoi_Click(object sender, EventArgs e)
        {
            string tigia;
            double s1;
            s1 = double.Parse(tb_tien_can_doi.Text);
            switch(cb_gia_tri.SelectedItem.ToString().Trim())
            {
                case "USD(Đô-la Mỹ)":
                    s1 = s1 * 22.772;
                    tigia = "1 USD = 22,772 VND";
                    tb_da_doi.Text = s1.ToString();
                    tb_tigia.Text = tigia.ToString();
                    break;
                case "EUR(Euro)":
                    s1 = s1 * 28.132;
                    tigia = "1 EUR = 28,132 VND";
                    tb_da_doi.Text = s1.ToString();
                    tb_tigia.Text = tigia.ToString();
                    break;
                case "GBP(Bảng Anh)":
                    s1 = s1 * 31.538;
                    tigia = "1 GBP = 31,538 VND";
                    tb_da_doi.Text = s1.ToString();
                    tb_tigia.Text = tigia.ToString();
                    break;
                case "SGD(Đô-la Singapore)":
                    s1 = s1 * 17.286;
                    tigia = "1 SGD = 17,286 VND";
                    tb_da_doi.Text = s1.ToString();
                    tb_tigia.Text = tigia.ToString();
                    break;
                case "JPY(Yên)":
                    s1 = s1 * 214;
                    tigia = "1 JPY = 214 VND";
                    tb_da_doi.Text = s1.ToString();
                    tb_tigia.Text = tigia.ToString();
                    break;
            }

        }
    }
}
