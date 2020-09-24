namespace TCP_Client_Multi
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
            this.textBox_File = new System.Windows.Forms.TextBox();
            this.button_Dlg = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_Host = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_File
            // 
            this.textBox_File.Location = new System.Drawing.Point(79, 79);
            this.textBox_File.Name = "textBox_File";
            this.textBox_File.Size = new System.Drawing.Size(247, 20);
            this.textBox_File.TabIndex = 0;
            // 
            // button_Dlg
            // 
            this.button_Dlg.Location = new System.Drawing.Point(251, 105);
            this.button_Dlg.Name = "button_Dlg";
            this.button_Dlg.Size = new System.Drawing.Size(75, 23);
            this.button_Dlg.TabIndex = 1;
            this.button_Dlg.Text = "button1";
            this.button_Dlg.UseVisualStyleBackColor = true;
            this.button_Dlg.Click += new System.EventHandler(this.button_Dlg_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(333, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 277);
            this.listBox1.TabIndex = 2;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(207, 147);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(106, 46);
            this.button_Send.TabIndex = 3;
            this.button_Send.Text = "GONDER";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // textBox_Host
            // 
            this.textBox_Host.Location = new System.Drawing.Point(79, 27);
            this.textBox_Host.Name = "textBox_Host";
            this.textBox_Host.Size = new System.Drawing.Size(100, 20);
            this.textBox_Host.TabIndex = 0;
            this.textBox_Host.Text = "127.0.0.1";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(79, 53);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(100, 20);
            this.textBox_Port.TabIndex = 0;
            this.textBox_Port.Text = "5656";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_log
            // 
            this.textBox_log.BackColor = System.Drawing.Color.Black;
            this.textBox_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_log.ForeColor = System.Drawing.Color.White;
            this.textBox_log.Location = new System.Drawing.Point(12, 199);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(301, 105);
            this.textBox_log.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 316);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_Dlg);
            this.Controls.Add(this.textBox_Host);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.textBox_File);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_File;
        private System.Windows.Forms.Button button_Dlg;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TextBox textBox_Host;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_log;
    }
}

