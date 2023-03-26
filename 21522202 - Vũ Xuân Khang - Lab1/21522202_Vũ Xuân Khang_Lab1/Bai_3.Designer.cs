namespace WindowsFormsApp1
{
    partial class Bai_3
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
            this.lb_nhap = new System.Windows.Forms.Label();
            this.lb_kq = new System.Windows.Forms.Label();
            this.tb_nhap = new System.Windows.Forms.TextBox();
            this.tb_kq = new System.Windows.Forms.TextBox();
            this.bt_doc = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_nhap
            // 
            this.lb_nhap.AutoSize = true;
            this.lb_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhap.Location = new System.Drawing.Point(40, 85);
            this.lb_nhap.Name = "lb_nhap";
            this.lb_nhap.Size = new System.Drawing.Size(274, 20);
            this.lb_nhap.TabIndex = 0;
            this.lb_nhap.Text = "Nhập vào số nguyên từ 0 đến 9:";
            // 
            // lb_kq
            // 
            this.lb_kq.AutoSize = true;
            this.lb_kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kq.Location = new System.Drawing.Point(40, 263);
            this.lb_kq.Name = "lb_kq";
            this.lb_kq.Size = new System.Drawing.Size(79, 20);
            this.lb_kq.TabIndex = 1;
            this.lb_kq.Text = "Kết quả:";
            // 
            // tb_nhap
            // 
            this.tb_nhap.Location = new System.Drawing.Point(360, 83);
            this.tb_nhap.Name = "tb_nhap";
            this.tb_nhap.Size = new System.Drawing.Size(131, 22);
            this.tb_nhap.TabIndex = 2;
            // 
            // tb_kq
            // 
            this.tb_kq.Location = new System.Drawing.Point(44, 314);
            this.tb_kq.Name = "tb_kq";
            this.tb_kq.Size = new System.Drawing.Size(237, 22);
            this.tb_kq.TabIndex = 3;
            // 
            // bt_doc
            // 
            this.bt_doc.Location = new System.Drawing.Point(628, 83);
            this.bt_doc.Name = "bt_doc";
            this.bt_doc.Size = new System.Drawing.Size(92, 56);
            this.bt_doc.TabIndex = 4;
            this.bt_doc.Text = "Đọc";
            this.bt_doc.UseVisualStyleBackColor = true;
            this.bt_doc.Click += new System.EventHandler(this.bt_doc_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(628, 178);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(92, 56);
            this.bt_xoa.TabIndex = 5;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(628, 280);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(92, 56);
            this.bt_thoat.TabIndex = 6;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // Bai_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_doc);
            this.Controls.Add(this.tb_kq);
            this.Controls.Add(this.tb_nhap);
            this.Controls.Add(this.lb_kq);
            this.Controls.Add(this.lb_nhap);
            this.Name = "Bai_3";
            this.Text = "Bài 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nhap;
        private System.Windows.Forms.Label lb_kq;
        private System.Windows.Forms.TextBox tb_nhap;
        private System.Windows.Forms.TextBox tb_kq;
        private System.Windows.Forms.Button bt_doc;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_thoat;
    }
}