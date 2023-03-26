namespace WindowsFormsApp1
{
    partial class Bai_4
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
            this.lb_chuyendoi = new System.Windows.Forms.Label();
            this.lb_tien_can_doi = new System.Windows.Forms.Label();
            this.lb_da_doi = new System.Windows.Forms.Label();
            this.lb_tigia = new System.Windows.Forms.Label();
            this.bt_chuyendoi = new System.Windows.Forms.Button();
            this.tb_tien_can_doi = new System.Windows.Forms.TextBox();
            this.tb_da_doi = new System.Windows.Forms.TextBox();
            this.cb_gia_tri = new System.Windows.Forms.ComboBox();
            this.tb_tigia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_chuyendoi
            // 
            this.lb_chuyendoi.AutoSize = true;
            this.lb_chuyendoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chuyendoi.Location = new System.Drawing.Point(11, 9);
            this.lb_chuyendoi.Name = "lb_chuyendoi";
            this.lb_chuyendoi.Size = new System.Drawing.Size(187, 25);
            this.lb_chuyendoi.TabIndex = 0;
            this.lb_chuyendoi.Text = "Chuyển đổi tiền tệ";
            // 
            // lb_tien_can_doi
            // 
            this.lb_tien_can_doi.AutoSize = true;
            this.lb_tien_can_doi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tien_can_doi.Location = new System.Drawing.Point(12, 91);
            this.lb_tien_can_doi.Name = "lb_tien_can_doi";
            this.lb_tien_can_doi.Size = new System.Drawing.Size(125, 20);
            this.lb_tien_can_doi.TabIndex = 1;
            this.lb_tien_can_doi.Text = "Số tiền cần đổi:";
            // 
            // lb_da_doi
            // 
            this.lb_da_doi.AutoSize = true;
            this.lb_da_doi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_da_doi.Location = new System.Drawing.Point(12, 313);
            this.lb_da_doi.Name = "lb_da_doi";
            this.lb_da_doi.Size = new System.Drawing.Size(116, 20);
            this.lb_da_doi.TabIndex = 2;
            this.lb_da_doi.Text = "Số tiền đã đổi:";
            // 
            // lb_tigia
            // 
            this.lb_tigia.AutoSize = true;
            this.lb_tigia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tigia.Location = new System.Drawing.Point(12, 382);
            this.lb_tigia.Name = "lb_tigia";
            this.lb_tigia.Size = new System.Drawing.Size(113, 20);
            this.lb_tigia.TabIndex = 3;
            this.lb_tigia.Text = "Tỉ giá quy đổi:";
            // 
            // bt_chuyendoi
            // 
            this.bt_chuyendoi.Location = new System.Drawing.Point(16, 178);
            this.bt_chuyendoi.Name = "bt_chuyendoi";
            this.bt_chuyendoi.Size = new System.Drawing.Size(311, 53);
            this.bt_chuyendoi.TabIndex = 4;
            this.bt_chuyendoi.Text = "Chuyển đổi";
            this.bt_chuyendoi.UseVisualStyleBackColor = true;
            this.bt_chuyendoi.Click += new System.EventHandler(this.bt_chuyendoi_Click);
            // 
            // tb_tien_can_doi
            // 
            this.tb_tien_can_doi.Location = new System.Drawing.Point(156, 89);
            this.tb_tien_can_doi.Name = "tb_tien_can_doi";
            this.tb_tien_can_doi.Size = new System.Drawing.Size(171, 22);
            this.tb_tien_can_doi.TabIndex = 5;
            // 
            // tb_da_doi
            // 
            this.tb_da_doi.Location = new System.Drawing.Point(156, 311);
            this.tb_da_doi.Name = "tb_da_doi";
            this.tb_da_doi.Size = new System.Drawing.Size(171, 22);
            this.tb_da_doi.TabIndex = 6;
            // 
            // cb_gia_tri
            // 
            this.cb_gia_tri.FormattingEnabled = true;
            this.cb_gia_tri.Items.AddRange(new object[] {
            "USD(Đô-la Mỹ)",
            "EUR(Euro)",
            "GBP(Bảng Anh)",
            "SGD(Đô-la Singapore)",
            "JPY(Yên)"});
            this.cb_gia_tri.Location = new System.Drawing.Point(435, 87);
            this.cb_gia_tri.Name = "cb_gia_tri";
            this.cb_gia_tri.Size = new System.Drawing.Size(208, 24);
            this.cb_gia_tri.TabIndex = 7;
            // 
            // tb_tigia
            // 
            this.tb_tigia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tigia.Location = new System.Drawing.Point(156, 382);
            this.tb_tigia.Name = "tb_tigia";
            this.tb_tigia.Size = new System.Drawing.Size(171, 22);
            this.tb_tigia.TabIndex = 8;
            // 
            // Bai_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_tigia);
            this.Controls.Add(this.cb_gia_tri);
            this.Controls.Add(this.tb_da_doi);
            this.Controls.Add(this.tb_tien_can_doi);
            this.Controls.Add(this.bt_chuyendoi);
            this.Controls.Add(this.lb_tigia);
            this.Controls.Add(this.lb_da_doi);
            this.Controls.Add(this.lb_tien_can_doi);
            this.Controls.Add(this.lb_chuyendoi);
            this.Name = "Bai_4";
            this.Text = "Bài 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_chuyendoi;
        private System.Windows.Forms.Label lb_tien_can_doi;
        private System.Windows.Forms.Label lb_da_doi;
        private System.Windows.Forms.Label lb_tigia;
        private System.Windows.Forms.Button bt_chuyendoi;
        private System.Windows.Forms.TextBox tb_tien_can_doi;
        private System.Windows.Forms.TextBox tb_da_doi;
        private System.Windows.Forms.ComboBox cb_gia_tri;
        private System.Windows.Forms.TextBox tb_tigia;
    }
}