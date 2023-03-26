namespace WindowsFormsApp1
{
    partial class Bai_5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_nhap_A = new System.Windows.Forms.Label();
            this.lb_nhap_B = new System.Windows.Forms.Label();
            this.bt_tinh = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.gb_kq = new System.Windows.Forms.GroupBox();
            this.tb_A_factorial = new System.Windows.Forms.TextBox();
            this.tb_sum_A = new System.Windows.Forms.TextBox();
            this.tb_B_factorial = new System.Windows.Forms.TextBox();
            this.tb_nhap_A = new System.Windows.Forms.TextBox();
            this.tb_nhap_B = new System.Windows.Forms.TextBox();
            this.tb_sum_B = new System.Windows.Forms.TextBox();
            this.tb_a_mu_b = new System.Windows.Forms.TextBox();
            this.gb_kq.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_nhap_A
            // 
            this.lb_nhap_A.AutoSize = true;
            this.lb_nhap_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhap_A.Location = new System.Drawing.Point(12, 34);
            this.lb_nhap_A.Name = "lb_nhap_A";
            this.lb_nhap_A.Size = new System.Drawing.Size(69, 20);
            this.lb_nhap_A.TabIndex = 0;
            this.lb_nhap_A.Text = "Nhập A:";
            // 
            // lb_nhap_B
            // 
            this.lb_nhap_B.AutoSize = true;
            this.lb_nhap_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhap_B.Location = new System.Drawing.Point(448, 36);
            this.lb_nhap_B.Name = "lb_nhap_B";
            this.lb_nhap_B.Size = new System.Drawing.Size(70, 20);
            this.lb_nhap_B.TabIndex = 1;
            this.lb_nhap_B.Text = "Nhập B:";
            // 
            // bt_tinh
            // 
            this.bt_tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tinh.Location = new System.Drawing.Point(16, 120);
            this.bt_tinh.Name = "bt_tinh";
            this.bt_tinh.Size = new System.Drawing.Size(324, 55);
            this.bt_tinh.TabIndex = 4;
            this.bt_tinh.Text = "Tính các giá trị";
            this.bt_tinh.UseVisualStyleBackColor = true;
            this.bt_tinh.Click += new System.EventHandler(this.bt_tinh_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(452, 120);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(110, 55);
            this.bt_xoa.TabIndex = 5;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(622, 120);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(110, 55);
            this.bt_thoat.TabIndex = 6;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // gb_kq
            // 
            this.gb_kq.Controls.Add(this.tb_a_mu_b);
            this.gb_kq.Controls.Add(this.tb_sum_B);
            this.gb_kq.Controls.Add(this.tb_sum_A);
            this.gb_kq.Controls.Add(this.tb_B_factorial);
            this.gb_kq.Controls.Add(this.tb_A_factorial);
            this.gb_kq.Location = new System.Drawing.Point(16, 211);
            this.gb_kq.Name = "gb_kq";
            this.gb_kq.Size = new System.Drawing.Size(716, 196);
            this.gb_kq.TabIndex = 8;
            this.gb_kq.TabStop = false;
            this.gb_kq.Text = "KẾT QUẢ:";
            // 
            // tb_A_factorial
            // 
            this.tb_A_factorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_A_factorial.Location = new System.Drawing.Point(6, 21);
            this.tb_A_factorial.Name = "tb_A_factorial";
            this.tb_A_factorial.Size = new System.Drawing.Size(318, 15);
            this.tb_A_factorial.TabIndex = 9;
            this.tb_A_factorial.TextChanged += new System.EventHandler(this.tb_A_factorial_TextChanged);
            // 
            // tb_sum_A
            // 
            this.tb_sum_A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_sum_A.Location = new System.Drawing.Point(6, 69);
            this.tb_sum_A.Name = "tb_sum_A";
            this.tb_sum_A.Size = new System.Drawing.Size(318, 15);
            this.tb_sum_A.TabIndex = 10;
            this.tb_sum_A.TextChanged += new System.EventHandler(this.tb_sum_A_TextChanged);
            // 
            // tb_B_factorial
            // 
            this.tb_B_factorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_B_factorial.Location = new System.Drawing.Point(392, 21);
            this.tb_B_factorial.Name = "tb_B_factorial";
            this.tb_B_factorial.Size = new System.Drawing.Size(318, 15);
            this.tb_B_factorial.TabIndex = 11;
            this.tb_B_factorial.TextChanged += new System.EventHandler(this.tb_B_factorial_TextChanged);
            // 
            // tb_nhap_A
            // 
            this.tb_nhap_A.Location = new System.Drawing.Point(87, 34);
            this.tb_nhap_A.Name = "tb_nhap_A";
            this.tb_nhap_A.Size = new System.Drawing.Size(208, 22);
            this.tb_nhap_A.TabIndex = 12;
            // 
            // tb_nhap_B
            // 
            this.tb_nhap_B.Location = new System.Drawing.Point(524, 36);
            this.tb_nhap_B.Name = "tb_nhap_B";
            this.tb_nhap_B.Size = new System.Drawing.Size(208, 22);
            this.tb_nhap_B.TabIndex = 13;
            // 
            // tb_sum_B
            // 
            this.tb_sum_B.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_sum_B.Location = new System.Drawing.Point(6, 118);
            this.tb_sum_B.Name = "tb_sum_B";
            this.tb_sum_B.Size = new System.Drawing.Size(318, 15);
            this.tb_sum_B.TabIndex = 12;
            this.tb_sum_B.TextChanged += new System.EventHandler(this.tb_sum_B_TextChanged);
            // 
            // tb_a_mu_b
            // 
            this.tb_a_mu_b.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_a_mu_b.Location = new System.Drawing.Point(6, 168);
            this.tb_a_mu_b.Name = "tb_a_mu_b";
            this.tb_a_mu_b.Size = new System.Drawing.Size(318, 15);
            this.tb_a_mu_b.TabIndex = 13;
            this.tb_a_mu_b.TextChanged += new System.EventHandler(this.tb_a_mu_b_TextChanged);
            // 
            // Bai_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_nhap_B);
            this.Controls.Add(this.gb_kq);
            this.Controls.Add(this.tb_nhap_A);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_tinh);
            this.Controls.Add(this.lb_nhap_B);
            this.Controls.Add(this.lb_nhap_A);
            this.Name = "Bai_5";
            this.Text = "Bài 5";
            this.gb_kq.ResumeLayout(false);
            this.gb_kq.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nhap_A;
        private System.Windows.Forms.Label lb_nhap_B;
        private System.Windows.Forms.Button bt_tinh;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.GroupBox gb_kq;
        private System.Windows.Forms.TextBox tb_sum_A;
        private System.Windows.Forms.TextBox tb_B_factorial;
        private System.Windows.Forms.TextBox tb_A_factorial;
        private System.Windows.Forms.TextBox tb_nhap_B;
        private System.Windows.Forms.TextBox tb_nhap_A;
        private System.Windows.Forms.TextBox tb_sum_B;
        private System.Windows.Forms.TextBox tb_a_mu_b;
    }
}