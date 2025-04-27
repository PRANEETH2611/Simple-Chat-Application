namespace ChatServerGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtRemoteIp;
        private System.Windows.Forms.TextBox txtInMSG;
        private System.Windows.Forms.TextBox txtMSG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtRemoteIp = new System.Windows.Forms.TextBox();
            this.txtInMSG = new System.Windows.Forms.TextBox();
            this.txtMSG = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRemoteIp
            // 
            this.txtRemoteIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtRemoteIp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRemoteIp.ForeColor = System.Drawing.Color.White;
            this.txtRemoteIp.Location = new System.Drawing.Point(12, 12);
            this.txtRemoteIp.Name = "txtRemoteIp";
            this.txtRemoteIp.Size = new System.Drawing.Size(200, 30);
            this.txtRemoteIp.TabIndex = 0;
            this.txtRemoteIp.Text = "127.0.0.1";
            // 
            // txtInMSG
            // 
            this.txtInMSG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtInMSG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtInMSG.ForeColor = System.Drawing.Color.White;
            this.txtInMSG.Location = new System.Drawing.Point(12, 56);
            this.txtInMSG.Multiline = true;
            this.txtInMSG.Name = "txtInMSG";
            this.txtInMSG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInMSG.Size = new System.Drawing.Size(616, 362);
            this.txtInMSG.TabIndex = 1;
            // 
            // txtMSG
            // 
            this.txtMSG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtMSG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMSG.ForeColor = System.Drawing.Color.White;
            this.txtMSG.Location = new System.Drawing.Point(14, 424);
            this.txtMSG.Name = "txtMSG";
            this.txtMSG.Size = new System.Drawing.Size(504, 30);
            this.txtMSG.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(343, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Server";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(524, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "SEND ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(640, 466);
            this.Controls.Add(this.txtInMSG);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMSG);
            this.Controls.Add(this.txtRemoteIp);
            this.Name = "Form1";
            this.Text = "Chat Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
