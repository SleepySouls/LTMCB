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
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void bt_bai1_Click(object sender, EventArgs e)
        {
            Bai_1 form2 = new Bai_1();
            form2.Show();
        }

        private void bt_bai2_Click(object sender, EventArgs e)
        {
            Bai_2 form3 = new Bai_2();
            form3.Show();
        }

        private void bt_bai3_Click(object sender, EventArgs e)
        {
            Bai_3 form3 = new Bai_3();
            form3.Show();
        }

        private void bt_bai4_Click(object sender, EventArgs e)
        {
            Bai_4 form4 = new Bai_4();
            form4.Show();
        }

        private void bt_bai5_Click(object sender, EventArgs e)
        {
            Bai_5 form5 = new Bai_5();
            form5.Show();
        }
    }
}
