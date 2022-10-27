namespace Server_TPS_first
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
            this.kill_server = new System.Windows.Forms.Button();
            this.activities_lv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // kill_server
            // 
            this.kill_server.Location = new System.Drawing.Point(655, 383);
            this.kill_server.Name = "kill_server";
            this.kill_server.Size = new System.Drawing.Size(133, 55);
            this.kill_server.TabIndex = 1;
            this.kill_server.Text = "Stop";
            this.kill_server.UseVisualStyleBackColor = true;
            // 
            // activities_lv
            // 
            this.activities_lv.Location = new System.Drawing.Point(12, 12);
            this.activities_lv.Name = "activities_lv";
            this.activities_lv.Size = new System.Drawing.Size(776, 331);
            this.activities_lv.TabIndex = 2;
            this.activities_lv.UseCompatibleStateImageBehavior = false;
            this.activities_lv.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.activities_lv);
            this.Controls.Add(this.kill_server);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button kill_server;
        private ListView activities_lv;
    }
}