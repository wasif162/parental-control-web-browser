namespace web_browser1st
{
    partial class Parent_Reg_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent_Reg_Form));
            this.Heading = new System.Windows.Forms.Label();
            this.UserLogBtn = new System.Windows.Forms.Button();
            this.UserLogPass = new System.Windows.Forms.TextBox();
            this.UserLogName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MonLogPass = new System.Windows.Forms.Label();
            this.MonLogName = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.Heading.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Heading.Location = new System.Drawing.Point(-5, -35);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(299, 30);
            this.Heading.TabIndex = 7;
            this.Heading.Text = "MONITOR LOGIN FORM";
            this.Heading.Click += new System.EventHandler(this.Heading_Click);
            // 
            // UserLogBtn
            // 
            this.UserLogBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.UserLogBtn.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogBtn.ForeColor = System.Drawing.Color.White;
            this.UserLogBtn.Location = new System.Drawing.Point(177, 356);
            this.UserLogBtn.Name = "UserLogBtn";
            this.UserLogBtn.Size = new System.Drawing.Size(128, 54);
            this.UserLogBtn.TabIndex = 7;
            this.UserLogBtn.Text = "Register";
            this.UserLogBtn.UseVisualStyleBackColor = false;
            this.UserLogBtn.Click += new System.EventHandler(this.UserLogBtn_Click);
            // 
            // UserLogPass
            // 
            this.UserLogPass.Location = new System.Drawing.Point(232, 289);
            this.UserLogPass.Multiline = true;
            this.UserLogPass.Name = "UserLogPass";
            this.UserLogPass.PasswordChar = '*';
            this.UserLogPass.Size = new System.Drawing.Size(156, 25);
            this.UserLogPass.TabIndex = 1;
            this.UserLogPass.TextChanged += new System.EventHandler(this.UserLogPass_TextChanged);
            // 
            // UserLogName
            // 
            this.UserLogName.Location = new System.Drawing.Point(233, 214);
            this.UserLogName.Multiline = true;
            this.UserLogName.Name = "UserLogName";
            this.UserLogName.Size = new System.Drawing.Size(156, 22);
            this.UserLogName.TabIndex = 0;
            this.UserLogName.TextChanged += new System.EventHandler(this.UserLogName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(63, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "PARENT REGISTRATION FORM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(11, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 45);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 35);
            this.label1.TabIndex = 23;
            this.label1.Text = "Parental Control Web Browser";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MonLogPass
            // 
            this.MonLogPass.AutoSize = true;
            this.MonLogPass.BackColor = System.Drawing.Color.Transparent;
            this.MonLogPass.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonLogPass.ForeColor = System.Drawing.Color.White;
            this.MonLogPass.Location = new System.Drawing.Point(93, 279);
            this.MonLogPass.Name = "MonLogPass";
            this.MonLogPass.Size = new System.Drawing.Size(115, 21);
            this.MonLogPass.TabIndex = 26;
            this.MonLogPass.Text = "password";
            this.MonLogPass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MonLogPass.Click += new System.EventHandler(this.MonLogPass_Click);
            // 
            // MonLogName
            // 
            this.MonLogName.AutoSize = true;
            this.MonLogName.BackColor = System.Drawing.Color.Transparent;
            this.MonLogName.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonLogName.ForeColor = System.Drawing.Color.White;
            this.MonLogName.Location = new System.Drawing.Point(86, 214);
            this.MonLogName.Name = "MonLogName";
            this.MonLogName.Size = new System.Drawing.Size(122, 21);
            this.MonLogName.TabIndex = 25;
            this.MonLogName.Text = "USER NAME";
            this.MonLogName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MonLogName.Click += new System.EventHandler(this.MonLogName_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(426, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 39);
            this.button6.TabIndex = 59;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Parent_Reg_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::web_browser1st.Properties.Resources.Untitled_7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(482, 577);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.MonLogPass);
            this.Controls.Add(this.MonLogName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserLogBtn);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.UserLogPass);
            this.Controls.Add(this.UserLogName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parent_Reg_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parent_Reg_Form";
            this.Load += new System.EventHandler(this.Parent_Reg_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Button UserLogBtn;
        private System.Windows.Forms.TextBox UserLogPass;
        private System.Windows.Forms.TextBox UserLogName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MonLogPass;
        private System.Windows.Forms.Label MonLogName;
        private System.Windows.Forms.Button button6;
    }
}