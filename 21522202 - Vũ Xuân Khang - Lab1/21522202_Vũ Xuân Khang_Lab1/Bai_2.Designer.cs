namespace WindowsFormsApp1
{
    partial class Bai_2
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
            this.lb_s3 = new System.Windows.Forms.Label();
            this.lb_sln = new System.Windows.Forms.Label();
            this.lb_snn = new System.Windows.Forms.Label();
            this.bt_tim = new System.Windows.Forms.Button();
            this.tb_sln = new System.Windows.Forms.TextBox();
            this.tb_snn = new System.Windows.Forms.TextBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.tb_s2 = new System.Windows.Forms.TextBox();
            this.tb_s1 = new System.Windows.Forms.TextBox();
            this.tb_s3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_s1
            // 
            this.lb_s1.AutoSize = true;
            this.lb_s1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_s1.Location = new System.Drawing.Point(12, 39);
            this.lb_s1.Name = "lb_s1";
            this.lb_s1.Size = new System.Drawing.Size(107, 20);
            this.lb_s1.TabIndex = 0;
            this.lb_s1.Text = "Số Thứ Nhất:";
            // 
            // lb_s2
            // 
            this.lb_s2.AutoSize = true;
            this.lb_s2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_s2.Location = new System.Drawing.Point(283, 39);
            this.lb_s2.Name = "lb_s2";
            this.lb_s2.Size = new System.Drawing.Size(98, 20);
            this.lb_s2.TabIndex = 1;
            this.lb_s2.Text = "Số Thứ Hai:";
            // 
            // lb_s3
            // 
            this.lb_s3.AutoSize = true;
            this.lb_s3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_s3.Location = new System.Drawing.Point(554, 39);
            this.lb_s3.Name = "lb_s3";
            this.lb_s3.Size = new System.Drawing.Size(93, 20);
            this.lb_s3.TabIndex = 2;
            this.lb_s3.Text = "Số Thứ Ba:";
            // 
            // lb_sln
            // 
            this.lb_sln.AutoSize = true;
            this.lb_sln.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sln.Location = new System.Drawing.Point(97, 343);
            this.lb_sln.Name = "lb_sln";
            this.lb_sln.Size = new System.Drawing.Size(127, 25);
            this.lb_sln.TabIndex = 6;
            this.lb_sln.Text = "Số Lớn Nhất:";
            // 
            // lb_snn
            // 
            this.lb_snn.AutoSize = true;
            this.lb_snn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_snn.Location = new System.Drawing.Point(465, 343);
            this.lb_snn.Name = "lb_snn";
            this.lb_snn.Size = new System.Drawing.Size(130, 25);
            this.lb_snn.TabIndex = 7;
            this.lb_snn.Text = "Số Nhỏ Nhất:";
            // 
            // bt_tim
            // 
            this.bt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.Location = new System.Drawing.Point(102, 157);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(157, 60);
            this.bt_tim.TabIndex = 8;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // tb_sln
            // 
            this.tb_sln.Location = new System.Drawing.Point(230, 346);
            this.tb_sln.Name = "tb_sln";
            this.tb_sln.Size = new System.Drawing.Size(100, 22);
            this.tb_sln.TabIndex = 11;
            // 
            // tb_snn
            // 
            this.tb_snn.Location = new System.Drawing.Point(601, 347);
            this.tb_snn.Name = "tb_snn";
            this.tb_snn.Size = new System.Drawing.Size(100, 22);
            this.tb_snn.TabIndex = 12;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(342, 157);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(157, 60);
            this.bt_xoa.TabIndex = 13;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(596, 157);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(157, 60);
            this.bt_thoat.TabIndex = 14;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // tb_s2
            // 
            this.tb_s2.Location = new System.Drawing.Point(387, 39);
            this.tb_s2.Name = "tb_s2";
            this.tb_s2.Size = new System.Drawing.Size(100, 22);
            this.tb_s2.TabIndex = 15;
            // 
            // tb_s1
            // 
            this.tb_s1.Location = new System.Drawing.Point(125, 39);
            this.tb_s1.Name = "tb_s1";
            this.tb_s1.Size = new System.Drawing.Size(100, 22);
            this.tb_s1.TabIndex = 17;
            // 
            // tb_s3
            // 
            this.tb_s3.Location = new System.Drawing.Point(653, 37);
            this.tb_s3.Name = "tb_s3";
            this.tb_s3.Size = new System.Drawing.Size(100, 22);
            this.tb_s3.TabIndex = 18;
            // 
            // Bai_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_s3);
            this.Controls.Add(this.tb_s1);
            this.Controls.Add(this.tb_s2);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.tb_snn);
            this.Controls.Add(this.tb_sln);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.lb_snn);
            this.Controls.Add(this.lb_sln);
            this.Controls.Add(this.lb_s3);
            this.Controls.Add(this.lb_s2);
            this.Controls.Add(this.lb_s1);
            this.Name = "Bai_2";
            this.Text = "Bài 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_s1;
        private System.Windows.Forms.Label lb_s2;
        private System.Windows.Forms.Label lb_s3;
        private System.Windows.Forms.Label lb_sln;
        private System.Windows.Forms.Label lb_snn;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.TextBox tb_sln;
        private System.Windows.Forms.TextBox tb_snn;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.TextBox tb_s2;
        private System.Windows.Forms.TextBox tb_s1;
        private System.Windows.Forms.TextBox tb_s3;
    }
}