namespace WindowsFormsApp1
{
    partial class Bai_1
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
            this.lb_s1 = new System.Windows.Forms.Label();
            this.lb_s2 = new System.Windows.Forms.Label();
            this.tb_s1 = new System.Windows.Forms.TextBox();
            this.tb_s2 = new System.Windows.Forms.TextBox();
            this.lb_kq = new System.Windows.Forms.Label();
            this.bt_calculate = new System.Windows.Forms.Button();
            this.lb_sum_int = new System.Windows.Forms.Label();
            this.tb_kq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_s1
            // 
            this.lb_s1.AutoSize = true;
            this.lb_s1.Location = new System.Drawing.Point(102, 96);
            this.lb_s1.Name = "lb_s1";
            this.lb_s1.Size = new System.Drawing.Size(54, 16);
            this.lb_s1.TabIndex = 0;
            this.lb_s1.Text = "Số thứ 1";
            // 
            // lb_s2
            // 
            this.lb_s2.AutoSize = true;
            this.lb_s2.Location = new System.Drawing.Point(102, 179);
            this.lb_s2.Name = "lb_s2";
            this.lb_s2.Size = new System.Drawing.Size(54, 16);
            this.lb_s2.TabIndex = 1;
            this.lb_s2.Text = "Số thứ 2";
            // 
            // tb_s1
            // 
            this.tb_s1.Location = new System.Drawing.Point(280, 96);
            this.tb_s1.Name = "tb_s1";
            this.tb_s1.Size = new System.Drawing.Size(241, 22);
            this.tb_s1.TabIndex = 2;
            this.tb_s1.TextChanged += new System.EventHandler(this.tb_s1_TextChanged);
            // 
            // tb_s2
            // 
            this.tb_s2.Location = new System.Drawing.Point(280, 179);
            this.tb_s2.Name = "tb_s2";
            this.tb_s2.Size = new System.Drawing.Size(241, 22);
            this.tb_s2.TabIndex = 3;
            this.tb_s2.TextChanged += new System.EventHandler(this.tb_s2_TextChanged);
            // 
            // lb_kq
            // 
            this.lb_kq.AutoSize = true;
            this.lb_kq.Location = new System.Drawing.Point(102, 276);
            this.lb_kq.Name = "lb_kq";
            this.lb_kq.Size = new System.Drawing.Size(55, 16);
            this.lb_kq.TabIndex = 4;
            this.lb_kq.Text = "Kết quả:";
            // 
            // bt_calculate
            // 
            this.bt_calculate.Location = new System.Drawing.Point(246, 365);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(318, 38);
            this.bt_calculate.TabIndex = 6;
            this.bt_calculate.Text = "Tính";
            this.bt_calculate.UseVisualStyleBackColor = true;
            this.bt_calculate.Click += new System.EventHandler(this.bt_calculate_Click);
            // 
            // lb_sum_int
            // 
            this.lb_sum_int.AutoSize = true;
            this.lb_sum_int.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sum_int.Location = new System.Drawing.Point(217, 18);
            this.lb_sum_int.Name = "lb_sum_int";
            this.lb_sum_int.Size = new System.Drawing.Size(368, 32);
            this.lb_sum_int.TabIndex = 7;
            this.lb_sum_int.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            // 
            // tb_kq
            // 
            this.tb_kq.Location = new System.Drawing.Point(280, 276);
            this.tb_kq.Name = "tb_kq";
            this.tb_kq.Size = new System.Drawing.Size(241, 22);
            this.tb_kq.TabIndex = 8;
            // 
            // Bai_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_kq);
            this.Controls.Add(this.lb_sum_int);
            this.Controls.Add(this.bt_calculate);
            this.Controls.Add(this.lb_kq);
            this.Controls.Add(this.tb_s2);
            this.Controls.Add(this.tb_s1);
            this.Controls.Add(this.lb_s2);
            this.Controls.Add(this.lb_s1);
            this.Name = "Bai_1";
            this.Text = "Bài 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_s1;
        private System.Windows.Forms.Label lb_s2;
        private System.Windows.Forms.TextBox tb_s1;
        private System.Windows.Forms.TextBox tb_s2;
        private System.Windows.Forms.Label lb_kq;
        private System.Windows.Forms.Button bt_calculate;
        private System.Windows.Forms.Label lb_sum_int;
        private System.Windows.Forms.TextBox tb_kq;
    }
}