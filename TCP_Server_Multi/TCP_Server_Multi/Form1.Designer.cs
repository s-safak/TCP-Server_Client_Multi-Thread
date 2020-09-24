namespace TCP_Server_Multi
{
    partial class Form1
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
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.listBox_Receive = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Folder = new System.Windows.Forms.Label();
            this.button_Folder = new System.Windows.Forms.Button();
            this.comboBox_Host = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(79, 60);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(55, 20);
            this.textBox_port.TabIndex = 1;
            this.textBox_port.Text = "5656";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host IP : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port : ";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(199, 57);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "Start Server";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Enabled = false;
            this.button_Stop.Location = new System.Drawing.Point(199, 86);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_Stop.TabIndex = 3;
            this.button_Stop.Text = "Stop Server";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 383);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(491, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // listBox_Receive
            // 
            this.listBox_Receive.FormattingEnabled = true;
            this.listBox_Receive.Location = new System.Drawing.Point(307, 31);
            this.listBox_Receive.Name = "listBox_Receive";
            this.listBox_Receive.Size = new System.Drawing.Size(183, 186);
            this.listBox_Receive.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Received Files";
            // 
            // textBox_log
            // 
            this.textBox_log.BackColor = System.Drawing.Color.Black;
            this.textBox_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_log.ForeColor = System.Drawing.Color.White;
            this.textBox_log.Location = new System.Drawing.Point(0, 115);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(301, 105);
            this.textBox_log.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Server Status : ";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Status.ForeColor = System.Drawing.Color.Red;
            this.label_Status.Location = new System.Drawing.Point(76, 96);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(58, 13);
            this.label_Status.TabIndex = 25;
            this.label_Status.Text = "OFFLINE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Receive Folder : ";
            // 
            // label_Folder
            // 
            this.label_Folder.AutoSize = true;
            this.label_Folder.Location = new System.Drawing.Point(94, 9);
            this.label_Folder.Name = "label_Folder";
            this.label_Folder.Size = new System.Drawing.Size(23, 13);
            this.label_Folder.TabIndex = 2;
            this.label_Folder.Text = "D:\\";
            // 
            // button_Folder
            // 
            this.button_Folder.Location = new System.Drawing.Point(199, 9);
            this.button_Folder.Name = "button_Folder";
            this.button_Folder.Size = new System.Drawing.Size(75, 23);
            this.button_Folder.TabIndex = 26;
            this.button_Folder.Text = "Select";
            this.button_Folder.UseVisualStyleBackColor = true;
            this.button_Folder.Click += new System.EventHandler(this.button_Folder_Click);
            // 
            // comboBox_Host
            // 
            this.comboBox_Host.FormattingEnabled = true;
            this.comboBox_Host.Location = new System.Drawing.Point(79, 33);
            this.comboBox_Host.Name = "comboBox_Host";
            this.comboBox_Host.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Host.TabIndex = 27;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 405);
            this.Controls.Add(this.comboBox_Host);
            this.Controls.Add(this.button_Folder);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.listBox_Receive);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Folder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_port);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Thread TCP Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox listBox_Receive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Folder;
        private System.Windows.Forms.Button button_Folder;
        private System.Windows.Forms.ComboBox comboBox_Host;
        private System.Windows.Forms.Timer timer1;
    }
}

