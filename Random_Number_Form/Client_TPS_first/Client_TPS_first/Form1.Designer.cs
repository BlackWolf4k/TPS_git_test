namespace Client_TPS_first
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.activities_lv = new System.Windows.Forms.ListView();
            this.message_tb = new System.Windows.Forms.TextBox();
            this.send_b = new System.Windows.Forms.Button();
            this.ip_tb = new System.Windows.Forms.TextBox();
            this.port_tb = new System.Windows.Forms.TextBox();
            this.connect_b = new System.Windows.Forms.Button();
            this.disconnect_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activities_lv
            // 
            this.activities_lv.Location = new System.Drawing.Point(12, 12);
            this.activities_lv.Name = "activities_lv";
            this.activities_lv.Size = new System.Drawing.Size(776, 211);
            this.activities_lv.TabIndex = 0;
            this.activities_lv.UseCompatibleStateImageBehavior = false;
            this.activities_lv.View = System.Windows.Forms.View.Details;
            // 
            // message_tb
            // 
            this.message_tb.Location = new System.Drawing.Point(342, 257);
            this.message_tb.Name = "message_tb";
            this.message_tb.Size = new System.Drawing.Size(421, 23);
            this.message_tb.TabIndex = 1;
            // 
            // send_b
            // 
            this.send_b.Location = new System.Drawing.Point(482, 316);
            this.send_b.Name = "send_b";
            this.send_b.Size = new System.Drawing.Size(149, 51);
            this.send_b.TabIndex = 2;
            this.send_b.Text = "Send";
            this.send_b.UseVisualStyleBackColor = true;
            this.send_b.Click += new System.EventHandler(this.send);
            // 
            // ip_tb
            // 
            this.ip_tb.Location = new System.Drawing.Point(28, 248);
            this.ip_tb.MaxLength = 15;
            this.ip_tb.Name = "ip_tb";
            this.ip_tb.Size = new System.Drawing.Size(100, 23);
            this.ip_tb.TabIndex = 3;
            // 
            // port_tb
            // 
            this.port_tb.Location = new System.Drawing.Point(134, 248);
            this.port_tb.MaxLength = 5;
            this.port_tb.Name = "port_tb";
            this.port_tb.Size = new System.Drawing.Size(100, 23);
            this.port_tb.TabIndex = 4;
            // 
            // connect_b
            // 
            this.connect_b.Location = new System.Drawing.Point(89, 330);
            this.connect_b.Name = "connect_b";
            this.connect_b.Size = new System.Drawing.Size(75, 23);
            this.connect_b.TabIndex = 5;
            this.connect_b.Text = "Connect";
            this.connect_b.UseVisualStyleBackColor = true;
            this.connect_b.Click += new System.EventHandler(this.connect);
            // 
            // disconnect_b
            // 
            this.disconnect_b.Location = new System.Drawing.Point(89, 359);
            this.disconnect_b.Name = "disconnect_b";
            this.disconnect_b.Size = new System.Drawing.Size(75, 23);
            this.disconnect_b.TabIndex = 6;
            this.disconnect_b.Text = "Disconnect";
            this.disconnect_b.UseVisualStyleBackColor = true;
            this.disconnect_b.Click += new System.EventHandler(this.disconnect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.disconnect_b);
            this.Controls.Add(this.connect_b);
            this.Controls.Add(this.port_tb);
            this.Controls.Add(this.ip_tb);
            this.Controls.Add(this.send_b);
            this.Controls.Add(this.message_tb);
            this.Controls.Add(this.activities_lv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView activities_lv;
        private TextBox message_tb;
        private Button send_b;
        private TextBox ip_tb;
        private TextBox port_tb;
        private Button connect_b;
        private Button disconnect_b;
    }
}