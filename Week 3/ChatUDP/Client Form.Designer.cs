namespace ChatUDP
{
    partial class client_chat
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
            this.components = new System.ComponentModel.Container();
            this.tb_chatbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ClientPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstSent = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ServerIpAddress = new System.Windows.Forms.TextBox();
            this.tb_ServerPort = new System.Windows.Forms.TextBox();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_connect = new System.Windows.Forms.Button();
            this.bt_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_chatbox
            // 
            this.tb_chatbox.Location = new System.Drawing.Point(20, 56);
            this.tb_chatbox.Margin = new System.Windows.Forms.Padding(4);
            this.tb_chatbox.Multiline = true;
            this.tb_chatbox.Name = "tb_chatbox";
            this.tb_chatbox.Size = new System.Drawing.Size(410, 32);
            this.tb_chatbox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client\'s Port:";
            // 
            // tb_ClientPort
            // 
            this.tb_ClientPort.Location = new System.Drawing.Point(622, 20);
            this.tb_ClientPort.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ClientPort.Name = "tb_ClientPort";
            this.tb_ClientPort.Size = new System.Drawing.Size(188, 22);
            this.tb_ClientPort.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "ChatBox";
            // 
            // lstSent
            // 
            this.lstSent.FormattingEnabled = true;
            this.lstSent.ItemHeight = 16;
            this.lstSent.Location = new System.Drawing.Point(20, 117);
            this.lstSent.Margin = new System.Windows.Forms.Padding(4);
            this.lstSent.Name = "lstSent";
            this.lstSent.Size = new System.Drawing.Size(410, 244);
            this.lstSent.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(508, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server\'s IP Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Server\'s Port:";
            // 
            // tb_ServerIpAddress
            // 
            this.tb_ServerIpAddress.Location = new System.Drawing.Point(679, 56);
            this.tb_ServerIpAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ServerIpAddress.Name = "tb_ServerIpAddress";
            this.tb_ServerIpAddress.Size = new System.Drawing.Size(188, 22);
            this.tb_ServerIpAddress.TabIndex = 9;
            // 
            // tb_ServerPort
            // 
            this.tb_ServerPort.Location = new System.Drawing.Point(628, 92);
            this.tb_ServerPort.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ServerPort.Name = "tb_ServerPort";
            this.tb_ServerPort.Size = new System.Drawing.Size(189, 22);
            this.tb_ServerPort.TabIndex = 10;
            // 
            // bt_exit
            // 
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Location = new System.Drawing.Point(512, 271);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(144, 53);
            this.bt_exit.TabIndex = 12;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_connect
            // 
            this.bt_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_connect.Location = new System.Drawing.Point(512, 164);
            this.bt_connect.Margin = new System.Windows.Forms.Padding(4);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(144, 53);
            this.bt_connect.TabIndex = 13;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // bt_send
            // 
            this.bt_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_send.Location = new System.Drawing.Point(723, 164);
            this.bt_send.Margin = new System.Windows.Forms.Padding(4);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(144, 53);
            this.bt_send.TabIndex = 14;
            this.bt_send.Text = "Send";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // client_chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 554);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.bt_connect);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.tb_ServerPort);
            this.Controls.Add(this.tb_ServerIpAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstSent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_ClientPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_chatbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "client_chat";
            this.Text = "Client Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_chatbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ClientPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstSent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ServerIpAddress;
        private System.Windows.Forms.TextBox tb_ServerPort;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.Button bt_send;
    }
}

