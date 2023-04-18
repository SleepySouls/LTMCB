namespace Lab_2
{
    partial class bai_3
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
            this.rtb_content = new System.Windows.Forms.RichTextBox();
            this.bt_writefile = new System.Windows.Forms.Button();
            this.bt_readfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_content
            // 
            this.rtb_content.Location = new System.Drawing.Point(338, 87);
            this.rtb_content.Name = "rtb_content";
            this.rtb_content.Size = new System.Drawing.Size(440, 277);
            this.rtb_content.TabIndex = 8;
            this.rtb_content.Text = "";
            // 
            // bt_writefile
            // 
            this.bt_writefile.Location = new System.Drawing.Point(22, 256);
            this.bt_writefile.Name = "bt_writefile";
            this.bt_writefile.Size = new System.Drawing.Size(236, 108);
            this.bt_writefile.TabIndex = 7;
            this.bt_writefile.Text = "Ghi File";
            this.bt_writefile.UseVisualStyleBackColor = true;
            this.bt_writefile.Click += new System.EventHandler(this.bt_writefile_Click);
            // 
            // bt_readfile
            // 
            this.bt_readfile.Location = new System.Drawing.Point(22, 87);
            this.bt_readfile.Name = "bt_readfile";
            this.bt_readfile.Size = new System.Drawing.Size(236, 108);
            this.bt_readfile.TabIndex = 6;
            this.bt_readfile.Text = "Đọc File";
            this.bt_readfile.UseVisualStyleBackColor = true;
            this.bt_readfile.Click += new System.EventHandler(this.bt_readfile_Click);
            // 
            // bai_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_content);
            this.Controls.Add(this.bt_writefile);
            this.Controls.Add(this.bt_readfile);
            this.Name = "bai_3";
            this.Text = "Bài 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_content;
        private System.Windows.Forms.Button bt_writefile;
        private System.Windows.Forms.Button bt_readfile;
    }
}