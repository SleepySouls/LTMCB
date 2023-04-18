namespace Lab_2
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
            this.rtb_content = new System.Windows.Forms.RichTextBox();
            this.bt_writefile = new System.Windows.Forms.Button();
            this.bt_readfile = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.lb_write_name = new System.Windows.Forms.Label();
            this.lb_write_id = new System.Windows.Forms.Label();
            this.lb_write_course1 = new System.Windows.Forms.Label();
            this.lb_write_phone = new System.Windows.Forms.Label();
            this.lb_write_course2 = new System.Windows.Forms.Label();
            this.lb_write_course3 = new System.Windows.Forms.Label();
            this.tb_write_name = new System.Windows.Forms.TextBox();
            this.tb_write_id = new System.Windows.Forms.TextBox();
            this.tb_write_phone = new System.Windows.Forms.TextBox();
            this.tb_write_course3 = new System.Windows.Forms.TextBox();
            this.tb_write_course2 = new System.Windows.Forms.TextBox();
            this.tb_write_course1 = new System.Windows.Forms.TextBox();
            this.tb_read_course2 = new System.Windows.Forms.TextBox();
            this.tb_read_course1 = new System.Windows.Forms.TextBox();
            this.tb_read_phone = new System.Windows.Forms.TextBox();
            this.tb_read_id = new System.Windows.Forms.TextBox();
            this.tb_read_name = new System.Windows.Forms.TextBox();
            this.tb_read_course3 = new System.Windows.Forms.TextBox();
            this.tb_read_average = new System.Windows.Forms.TextBox();
            this.lb_read_name = new System.Windows.Forms.Label();
            this.lb_read_id = new System.Windows.Forms.Label();
            this.lb_read_phone = new System.Windows.Forms.Label();
            this.lb_read_course1 = new System.Windows.Forms.Label();
            this.lb_read_course2 = new System.Windows.Forms.Label();
            this.lb_read_course3 = new System.Windows.Forms.Label();
            this.lb_read_average = new System.Windows.Forms.Label();
            this.lb_page = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_content
            // 
            this.rtb_content.Location = new System.Drawing.Point(273, 12);
            this.rtb_content.Name = "rtb_content";
            this.rtb_content.Size = new System.Drawing.Size(232, 426);
            this.rtb_content.TabIndex = 0;
            this.rtb_content.Text = "";
            // 
            // bt_writefile
            // 
            this.bt_writefile.Location = new System.Drawing.Point(12, 12);
            this.bt_writefile.Name = "bt_writefile";
            this.bt_writefile.Size = new System.Drawing.Size(234, 39);
            this.bt_writefile.TabIndex = 1;
            this.bt_writefile.Text = "Write file";
            this.bt_writefile.UseVisualStyleBackColor = true;
            this.bt_writefile.Click += new System.EventHandler(this.bt_writefile_Click);
            // 
            // bt_readfile
            // 
            this.bt_readfile.Location = new System.Drawing.Point(554, 12);
            this.bt_readfile.Name = "bt_readfile";
            this.bt_readfile.Size = new System.Drawing.Size(234, 39);
            this.bt_readfile.TabIndex = 2;
            this.bt_readfile.Text = "Read file";
            this.bt_readfile.UseVisualStyleBackColor = true;
            this.bt_readfile.Click += new System.EventHandler(this.bt_readfile_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(69, 395);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(99, 43);
            this.bt_add.TabIndex = 3;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(536, 405);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(75, 23);
            this.bt_back.TabIndex = 4;
            this.bt_back.Text = "Back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(713, 405);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(75, 23);
            this.bt_next.TabIndex = 5;
            this.bt_next.Text = "Next";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // lb_write_name
            // 
            this.lb_write_name.AutoSize = true;
            this.lb_write_name.Location = new System.Drawing.Point(-1, 80);
            this.lb_write_name.Name = "lb_write_name";
            this.lb_write_name.Size = new System.Drawing.Size(47, 16);
            this.lb_write_name.TabIndex = 6;
            this.lb_write_name.Text = "Name:";
            // 
            // lb_write_id
            // 
            this.lb_write_id.AutoSize = true;
            this.lb_write_id.Location = new System.Drawing.Point(-1, 125);
            this.lb_write_id.Name = "lb_write_id";
            this.lb_write_id.Size = new System.Drawing.Size(23, 16);
            this.lb_write_id.TabIndex = 7;
            this.lb_write_id.Text = "ID:";
            // 
            // lb_write_course1
            // 
            this.lb_write_course1.AutoSize = true;
            this.lb_write_course1.Location = new System.Drawing.Point(-1, 216);
            this.lb_write_course1.Name = "lb_write_course1";
            this.lb_write_course1.Size = new System.Drawing.Size(63, 16);
            this.lb_write_course1.TabIndex = 8;
            this.lb_write_course1.Text = "Course 1:";
            // 
            // lb_write_phone
            // 
            this.lb_write_phone.AutoSize = true;
            this.lb_write_phone.Location = new System.Drawing.Point(-1, 174);
            this.lb_write_phone.Name = "lb_write_phone";
            this.lb_write_phone.Size = new System.Drawing.Size(49, 16);
            this.lb_write_phone.TabIndex = 9;
            this.lb_write_phone.Text = "Phone:";
            // 
            // lb_write_course2
            // 
            this.lb_write_course2.AutoSize = true;
            this.lb_write_course2.Location = new System.Drawing.Point(-1, 260);
            this.lb_write_course2.Name = "lb_write_course2";
            this.lb_write_course2.Size = new System.Drawing.Size(63, 16);
            this.lb_write_course2.TabIndex = 10;
            this.lb_write_course2.Text = "Course 2:";
            // 
            // lb_write_course3
            // 
            this.lb_write_course3.AutoSize = true;
            this.lb_write_course3.Location = new System.Drawing.Point(-1, 304);
            this.lb_write_course3.Name = "lb_write_course3";
            this.lb_write_course3.Size = new System.Drawing.Size(63, 16);
            this.lb_write_course3.TabIndex = 11;
            this.lb_write_course3.Text = "Course 3:";
            // 
            // tb_write_name
            // 
            this.tb_write_name.Location = new System.Drawing.Point(71, 77);
            this.tb_write_name.Name = "tb_write_name";
            this.tb_write_name.Size = new System.Drawing.Size(175, 22);
            this.tb_write_name.TabIndex = 20;
            // 
            // tb_write_id
            // 
            this.tb_write_id.Location = new System.Drawing.Point(71, 119);
            this.tb_write_id.Name = "tb_write_id";
            this.tb_write_id.Size = new System.Drawing.Size(175, 22);
            this.tb_write_id.TabIndex = 21;
            // 
            // tb_write_phone
            // 
            this.tb_write_phone.Location = new System.Drawing.Point(71, 168);
            this.tb_write_phone.Name = "tb_write_phone";
            this.tb_write_phone.Size = new System.Drawing.Size(175, 22);
            this.tb_write_phone.TabIndex = 22;
            // 
            // tb_write_course3
            // 
            this.tb_write_course3.Location = new System.Drawing.Point(71, 298);
            this.tb_write_course3.Name = "tb_write_course3";
            this.tb_write_course3.Size = new System.Drawing.Size(175, 22);
            this.tb_write_course3.TabIndex = 23;
            // 
            // tb_write_course2
            // 
            this.tb_write_course2.Location = new System.Drawing.Point(71, 254);
            this.tb_write_course2.Name = "tb_write_course2";
            this.tb_write_course2.Size = new System.Drawing.Size(175, 22);
            this.tb_write_course2.TabIndex = 24;
            // 
            // tb_write_course1
            // 
            this.tb_write_course1.Location = new System.Drawing.Point(71, 210);
            this.tb_write_course1.Name = "tb_write_course1";
            this.tb_write_course1.Size = new System.Drawing.Size(175, 22);
            this.tb_write_course1.TabIndex = 25;
            // 
            // tb_read_course2
            // 
            this.tb_read_course2.Location = new System.Drawing.Point(590, 254);
            this.tb_read_course2.Name = "tb_read_course2";
            this.tb_read_course2.Size = new System.Drawing.Size(175, 22);
            this.tb_read_course2.TabIndex = 27;
            // 
            // tb_read_course1
            // 
            this.tb_read_course1.Location = new System.Drawing.Point(590, 210);
            this.tb_read_course1.Name = "tb_read_course1";
            this.tb_read_course1.Size = new System.Drawing.Size(175, 22);
            this.tb_read_course1.TabIndex = 28;
            // 
            // tb_read_phone
            // 
            this.tb_read_phone.Location = new System.Drawing.Point(590, 168);
            this.tb_read_phone.Name = "tb_read_phone";
            this.tb_read_phone.Size = new System.Drawing.Size(175, 22);
            this.tb_read_phone.TabIndex = 29;
            // 
            // tb_read_id
            // 
            this.tb_read_id.Location = new System.Drawing.Point(590, 119);
            this.tb_read_id.Name = "tb_read_id";
            this.tb_read_id.Size = new System.Drawing.Size(175, 22);
            this.tb_read_id.TabIndex = 30;
            // 
            // tb_read_name
            // 
            this.tb_read_name.Location = new System.Drawing.Point(590, 77);
            this.tb_read_name.Name = "tb_read_name";
            this.tb_read_name.Size = new System.Drawing.Size(175, 22);
            this.tb_read_name.TabIndex = 31;
            // 
            // tb_read_course3
            // 
            this.tb_read_course3.Location = new System.Drawing.Point(590, 298);
            this.tb_read_course3.Name = "tb_read_course3";
            this.tb_read_course3.Size = new System.Drawing.Size(175, 22);
            this.tb_read_course3.TabIndex = 32;
            // 
            // tb_read_average
            // 
            this.tb_read_average.Location = new System.Drawing.Point(590, 345);
            this.tb_read_average.Name = "tb_read_average";
            this.tb_read_average.Size = new System.Drawing.Size(175, 22);
            this.tb_read_average.TabIndex = 33;
            // 
            // lb_read_name
            // 
            this.lb_read_name.AutoSize = true;
            this.lb_read_name.Location = new System.Drawing.Point(521, 83);
            this.lb_read_name.Name = "lb_read_name";
            this.lb_read_name.Size = new System.Drawing.Size(47, 16);
            this.lb_read_name.TabIndex = 34;
            this.lb_read_name.Text = "Name:";
            // 
            // lb_read_id
            // 
            this.lb_read_id.AutoSize = true;
            this.lb_read_id.Location = new System.Drawing.Point(521, 125);
            this.lb_read_id.Name = "lb_read_id";
            this.lb_read_id.Size = new System.Drawing.Size(23, 16);
            this.lb_read_id.TabIndex = 35;
            this.lb_read_id.Text = "ID:";
            // 
            // lb_read_phone
            // 
            this.lb_read_phone.AutoSize = true;
            this.lb_read_phone.Location = new System.Drawing.Point(521, 171);
            this.lb_read_phone.Name = "lb_read_phone";
            this.lb_read_phone.Size = new System.Drawing.Size(49, 16);
            this.lb_read_phone.TabIndex = 36;
            this.lb_read_phone.Text = "Phone:";
            // 
            // lb_read_course1
            // 
            this.lb_read_course1.AutoSize = true;
            this.lb_read_course1.Location = new System.Drawing.Point(521, 213);
            this.lb_read_course1.Name = "lb_read_course1";
            this.lb_read_course1.Size = new System.Drawing.Size(63, 16);
            this.lb_read_course1.TabIndex = 37;
            this.lb_read_course1.Text = "Course 1:";
            // 
            // lb_read_course2
            // 
            this.lb_read_course2.AutoSize = true;
            this.lb_read_course2.Location = new System.Drawing.Point(521, 257);
            this.lb_read_course2.Name = "lb_read_course2";
            this.lb_read_course2.Size = new System.Drawing.Size(63, 16);
            this.lb_read_course2.TabIndex = 38;
            this.lb_read_course2.Text = "Course 2:";
            // 
            // lb_read_course3
            // 
            this.lb_read_course3.AutoSize = true;
            this.lb_read_course3.Location = new System.Drawing.Point(521, 301);
            this.lb_read_course3.Name = "lb_read_course3";
            this.lb_read_course3.Size = new System.Drawing.Size(63, 16);
            this.lb_read_course3.TabIndex = 39;
            this.lb_read_course3.Text = "Course 3:";
            // 
            // lb_read_average
            // 
            this.lb_read_average.AutoSize = true;
            this.lb_read_average.Location = new System.Drawing.Point(521, 348);
            this.lb_read_average.Name = "lb_read_average";
            this.lb_read_average.Size = new System.Drawing.Size(62, 16);
            this.lb_read_average.TabIndex = 40;
            this.lb_read_average.Text = "Average:";
            // 
            // lb_page
            // 
            this.lb_page.AutoSize = true;
            this.lb_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_page.Location = new System.Drawing.Point(653, 405);
            this.lb_page.Name = "lb_page";
            this.lb_page.Size = new System.Drawing.Size(18, 20);
            this.lb_page.TabIndex = 41;
            this.lb_page.Text = "1";
            // 
            // Bai_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_page);
            this.Controls.Add(this.lb_read_average);
            this.Controls.Add(this.lb_read_course3);
            this.Controls.Add(this.lb_read_course2);
            this.Controls.Add(this.lb_read_course1);
            this.Controls.Add(this.lb_read_phone);
            this.Controls.Add(this.lb_read_id);
            this.Controls.Add(this.lb_read_name);
            this.Controls.Add(this.tb_read_average);
            this.Controls.Add(this.tb_read_course3);
            this.Controls.Add(this.tb_read_name);
            this.Controls.Add(this.tb_read_id);
            this.Controls.Add(this.tb_read_phone);
            this.Controls.Add(this.tb_read_course1);
            this.Controls.Add(this.tb_read_course2);
            this.Controls.Add(this.tb_write_course1);
            this.Controls.Add(this.tb_write_course2);
            this.Controls.Add(this.tb_write_course3);
            this.Controls.Add(this.tb_write_phone);
            this.Controls.Add(this.tb_write_id);
            this.Controls.Add(this.tb_write_name);
            this.Controls.Add(this.lb_write_course3);
            this.Controls.Add(this.lb_write_course2);
            this.Controls.Add(this.lb_write_phone);
            this.Controls.Add(this.lb_write_course1);
            this.Controls.Add(this.lb_write_id);
            this.Controls.Add(this.lb_write_name);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_readfile);
            this.Controls.Add(this.bt_writefile);
            this.Controls.Add(this.rtb_content);
            this.Name = "Bai_4";
            this.Text = "Bài 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_content;
        private System.Windows.Forms.Button bt_writefile;
        private System.Windows.Forms.Button bt_readfile;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Label lb_write_name;
        private System.Windows.Forms.Label lb_write_id;
        private System.Windows.Forms.Label lb_write_course1;
        private System.Windows.Forms.Label lb_write_phone;
        private System.Windows.Forms.Label lb_write_course2;
        private System.Windows.Forms.Label lb_write_course3;
        private System.Windows.Forms.TextBox tb_write_name;
        private System.Windows.Forms.TextBox tb_write_id;
        private System.Windows.Forms.TextBox tb_write_phone;
        private System.Windows.Forms.TextBox tb_write_course3;
        private System.Windows.Forms.TextBox tb_write_course2;
        private System.Windows.Forms.TextBox tb_write_course1;
        private System.Windows.Forms.TextBox tb_read_course2;
        private System.Windows.Forms.TextBox tb_read_course1;
        private System.Windows.Forms.TextBox tb_read_phone;
        private System.Windows.Forms.TextBox tb_read_id;
        private System.Windows.Forms.TextBox tb_read_name;
        private System.Windows.Forms.TextBox tb_read_course3;
        private System.Windows.Forms.TextBox tb_read_average;
        private System.Windows.Forms.Label lb_read_name;
        private System.Windows.Forms.Label lb_read_id;
        private System.Windows.Forms.Label lb_read_phone;
        private System.Windows.Forms.Label lb_read_course1;
        private System.Windows.Forms.Label lb_read_course2;
        private System.Windows.Forms.Label lb_read_course3;
        private System.Windows.Forms.Label lb_read_average;
        private System.Windows.Forms.Label lb_page;
    }
}