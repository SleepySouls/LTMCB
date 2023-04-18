namespace Lab_2
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
            this.label5 = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_charcount = new System.Windows.Forms.TextBox();
            this.tb_wordcount = new System.Windows.Forms.TextBox();
            this.tb_linecount = new System.Windows.Forms.TextBox();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.tb_filename = new System.Windows.Forms.TextBox();
            this.rtb_content = new System.Windows.Forms.RichTextBox();
            this.bt_readfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Line count:";
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(12, 406);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(356, 32);
            this.bt_exit.TabIndex = 29;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Character count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Word count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "File name:";
            // 
            // tb_charcount
            // 
            this.tb_charcount.Location = new System.Drawing.Point(130, 360);
            this.tb_charcount.Name = "tb_charcount";
            this.tb_charcount.Size = new System.Drawing.Size(238, 22);
            this.tb_charcount.TabIndex = 23;
            // 
            // tb_wordcount
            // 
            this.tb_wordcount.Location = new System.Drawing.Point(130, 308);
            this.tb_wordcount.Name = "tb_wordcount";
            this.tb_wordcount.Size = new System.Drawing.Size(238, 22);
            this.tb_wordcount.TabIndex = 22;
            // 
            // tb_linecount
            // 
            this.tb_linecount.Location = new System.Drawing.Point(130, 255);
            this.tb_linecount.Name = "tb_linecount";
            this.tb_linecount.Size = new System.Drawing.Size(238, 22);
            this.tb_linecount.TabIndex = 21;
            // 
            // tb_size
            // 
            this.tb_size.Location = new System.Drawing.Point(130, 138);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(238, 22);
            this.tb_size.TabIndex = 20;
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(130, 197);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(238, 22);
            this.tb_path.TabIndex = 19;
            // 
            // tb_filename
            // 
            this.tb_filename.Location = new System.Drawing.Point(130, 85);
            this.tb_filename.Name = "tb_filename";
            this.tb_filename.Size = new System.Drawing.Size(238, 22);
            this.tb_filename.TabIndex = 18;
            // 
            // rtb_content
            // 
            this.rtb_content.Location = new System.Drawing.Point(374, 12);
            this.rtb_content.Name = "rtb_content";
            this.rtb_content.Size = new System.Drawing.Size(414, 426);
            this.rtb_content.TabIndex = 17;
            this.rtb_content.Text = "";
            // 
            // bt_readfile
            // 
            this.bt_readfile.Location = new System.Drawing.Point(12, 12);
            this.bt_readfile.Name = "bt_readfile";
            this.bt_readfile.Size = new System.Drawing.Size(217, 47);
            this.bt_readfile.TabIndex = 16;
            this.bt_readfile.Text = "Read From File";
            this.bt_readfile.UseVisualStyleBackColor = true;
            this.bt_readfile.Click += new System.EventHandler(this.bt_readfile_Click);
            // 
            // Bai_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_charcount);
            this.Controls.Add(this.tb_wordcount);
            this.Controls.Add(this.tb_linecount);
            this.Controls.Add(this.tb_size);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.tb_filename);
            this.Controls.Add(this.rtb_content);
            this.Controls.Add(this.bt_readfile);
            this.Name = "Bai_2";
            this.Text = "Bài 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_charcount;
        private System.Windows.Forms.TextBox tb_wordcount;
        private System.Windows.Forms.TextBox tb_linecount;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.TextBox tb_filename;
        private System.Windows.Forms.RichTextBox rtb_content;
        private System.Windows.Forms.Button bt_readfile;
    }
}