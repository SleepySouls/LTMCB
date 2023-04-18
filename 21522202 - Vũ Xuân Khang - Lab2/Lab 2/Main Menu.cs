using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void bt_bai1_Click(object sender, EventArgs e)
        {
            Bai_1 b1 = new Bai_1();
            b1.Show();
        }

        private void bt_bai2_Click(object sender, EventArgs e)
        {
            Bai_2 b2 = new Bai_2();
            b2.Show();
        }

        private void bt_bai4_Click(object sender, EventArgs e)
        {
            Bai_4 b4 = new Bai_4();
            b4.Show();
        }

        private void bt_bai3_Click(object sender, EventArgs e)
        {
            bai_3 b3 = new bai_3();
            b3.Show();
        }

        private void Bai_5_Click(object sender, EventArgs e)
        {
            Bai_5 b5 = new Bai_5();
            b5.Show();
        }
    }
}
