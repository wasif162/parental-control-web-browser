namespace web_browser1st
{
    partial class login_form_for_clerar_by_monitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form_for_clerar_by_monitor));
            this.UserLogBtn = new System.Windows.Forms.Button();
            this.UserLogPass = new System.Windows.Forms.TextBox();
            this.UserLogName = new System.Windows.Forms.TextBox();
            this.MonLogPass = new System.Windows.Forms.Label();
            this.MonLogName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserLogBtn
            // 
            this.UserLogBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.UserLogBtn.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogBtn.ForeColor = System.Drawing.Color.White;
            this.UserLogBtn.Location = new System.Drawing.Point(173, 350);
            this.UserLogBtn.Name = "UserLogBtn";
            this.UserLogBtn.Size = new System.Drawing.Size(128, 54);
            this.UserLogBtn.TabIndex = 7;
            this.UserLogBtn.Text = "LOGIN";
            this.UserLogBtn.UseVisualStyleBackColor = false;
            this.UserLogBtn.Click += new System.EventHandler(this.UserLogBtn_Click);
            // 
            // UserLogPass
            // 
            this.UserLogPass.Location = new System.Drawing.Point(241, 269);
            this.UserLogPass.Multiline = true;
            this.UserLogPass.Name = "UserLogPass";
            this.UserLogPass.PasswordChar = '*';
            this.UserLogPass.Size = new System.Drawing.Size(156, 25);
            this.UserLogPass.TabIndex = 1;
            // 
            // UserLogName
            // 
            this.UserLogName.Location = new System.Drawing.Point(241, 211);
            this.UserLogName.Multiline = true;
            this.UserLogName.Name = "UserLogName";
            this.UserLogName.Size = new System.Drawing.Size(156, 25);
            this.UserLogName.TabIndex = 0;
            // 
            // MonLogPass
            // 
            this.MonLogPass.AutoSize = true;
            this.MonLogPass.BackColor = System.Drawing.Color.Transparent;
            this.MonLogPass.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonLogPass.ForeColor = System.Drawing.Color.White;
            this.MonLogPass.Location = new System.Drawing.Point(100, 272);
            this.MonLogPass.Name = "MonLogPass";
            this.MonLogPass.Size = new System.Drawing.Size(115, 21);
            this.MonLogPass.TabIndex = 31;
            this.MonLogPass.Text = "password";
            this.MonLogPass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MonLogName
            // 
            this.MonLogName.AutoSize = true;
            this.MonLogName.BackColor = System.Drawing.Color.Transparent;
            this.MonLogName.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonLogName.ForeColor = System.Drawing.Color.White;
            this.MonLogName.Location = new System.Drawing.Point(93, 207);
            this.MonLogName.Name = "MonLogName";
            this.MonLogName.Size = new System.Drawing.Size(122, 21);
            this.MonLogName.TabIndex = 30;
            this.MonLogName.Text = "USER NAME";
            this.MonLogName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(99, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 26);
            this.label2.TabIndex = 34;
            this.label2.Text = "MONITOR LOGIN FORM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 45);
            this.panel1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 35);
            this.label1.TabIndex = 32;
            this.label1.Text = "Parental Control Web Browser";
            // 
            // login_form_for_clerar_by_monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::web_browser1st.Properties.Resources.Untitled_7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(483, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MonLogPass);
            this.Controls.Add(this.MonLogName);
            this.Controls.Add(this.UserLogBtn);
            this.Controls.Add(this.UserLogPass);
            this.Controls.Add(this.UserLogName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_form_for_clerar_by_monitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "login_form_for_clerar_by_monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserLogBtn;
        private System.Windows.Forms.TextBox UserLogPass;
        private System.Windows.Forms.TextBox UserLogName;
        private System.Windows.Forms.Label MonLogPass;
        private System.Windows.Forms.Label MonLogName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}