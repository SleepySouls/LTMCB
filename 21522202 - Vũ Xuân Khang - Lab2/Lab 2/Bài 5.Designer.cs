namespace Lab_2
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
            this.bt_zip = new System.Windows.Forms.Button();
            this.bt_extract = new System.Windows.Forms.Button();
            this.bt_pathzip = new System.Windows.Forms.Button();
            this.bt_extractpath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pathtozip = new System.Windows.Forms.TextBox();
            this.tb_pathtoextract = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_zip
            // 
            this.bt_zip.Location = new System.Drawing.Point(511, 78);
            this.bt_zip.Name = "bt_zip";
            this.bt_zip.Size = new System.Drawing.Size(148, 83);
            this.bt_zip.TabIndex = 0;
            this.bt_zip.Text = "Zip";
            this.bt_zip.UseVisualStyleBackColor = true;
            this.bt_zip.Click += new System.EventHandler(this.bt_zip_Click);
            // 
            // bt_extract
            // 
            this.bt_extract.Location = new System.Drawing.Point(511, 251);
            this.bt_extract.Name = "bt_extract";
            this.bt_extract.Size = new System.Drawing.Size(148, 83);
            this.bt_extract.TabIndex = 1;
            this.bt_extract.Text = "Unzip";
            this.bt_extract.UseVisualStyleBackColor = true;
            this.bt_extract.Click += new System.EventHandler(this.bt_extract_Click);
            // 
            // bt_pathzip
            // 
            this.bt_pathzip.Location = new System.Drawing.Point(422, 112);
            this.bt_pathzip.Name = "bt_pathzip";
            this.bt_pathzip.Size = new System.Drawing.Size(36, 23);
            this.bt_pathzip.TabIndex = 2;
            this.bt_pathzip.Text = "...";
            this.bt_pathzip.UseVisualStyleBackColor = true;
            this.bt_pathzip.Click += new System.EventHandler(this.bt_pathzip_Click);
            // 
            // bt_extractpath
            // 
            this.bt_extractpath.Location = new System.Drawing.Point(422, 281);
            this.bt_extractpath.Name = "bt_extractpath";
            this.bt_extractpath.Size = new System.Drawing.Size(36, 23);
            this.bt_extractpath.TabIndex = 3;
            this.bt_extractpath.Text = "...";
            this.bt_extractpath.UseVisualStyleBackColor = true;
            this.bt_extractpath.Click += new System.EventHandler(this.bt_extractpath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path to Zip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path to Extract:";
            // 
            // tb_pathtozip
            // 
            this.tb_pathtozip.Location = new System.Drawing.Point(126, 112);
            this.tb_pathtozip.Name = "tb_pathtozip";
            this.tb_pathtozip.Size = new System.Drawing.Size(248, 22);
            this.tb_pathtozip.TabIndex = 6;
            // 
            // tb_pathtoextract
            // 
            this.tb_pathtoextract.Location = new System.Drawing.Point(126, 285);
            this.tb_pathtoextract.Name = "tb_pathtoextract";
            this.tb_pathtoextract.Size = new System.Drawing.Size(248, 22);
            this.tb_pathtoextract.TabIndex = 7;
            // 
            // Bai_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_pathtoextract);
            this.Controls.Add(this.tb_pathtozip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_extractpath);
            this.Controls.Add(this.bt_pathzip);
            this.Controls.Add(this.bt_extract);
            this.Controls.Add(this.bt_zip);
            this.Name = "Bai_5";
            this.Text = "Bài 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_zip;
        private System.Windows.Forms.Button bt_extract;
        private System.Windows.Forms.Button bt_pathzip;
        private System.Windows.Forms.Button bt_extractpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pathtozip;
        private System.Windows.Forms.TextBox tb_pathtoextract;
    }
}