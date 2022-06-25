namespace web_browser1st
{
    partial class webForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDDRESSURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.gOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDTABToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMOVEPAGEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDRESSURLToolStripMenuItem,
            this.toolStripComboBox1,
            this.gOToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.aDDTABToolStripMenuItem,
            this.rEMOVEPAGEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDDRESSURLToolStripMenuItem
            // 
            this.aDDRESSURLToolStripMenuItem.Name = "aDDRESSURLToolStripMenuItem";
            this.aDDRESSURLToolStripMenuItem.Size = new System.Drawing.Size(94, 23);
            this.aDDRESSURLToolStripMenuItem.Text = "ADDRESS/URL";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(500, 23);
            this.toolStripComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripComboBox1_KeyDown);
            // 
            // gOToolStripMenuItem
            // 
            this.gOToolStripMenuItem.Name = "gOToolStripMenuItem";
            this.gOToolStripMenuItem.Size = new System.Drawing.Size(36, 23);
            this.gOToolStripMenuItem.Text = "GO";
            this.gOToolStripMenuItem.Click += new System.EventHandler(this.gOToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 23);
            this.toolStripMenuItem1.Text = "<<<";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(43, 23);
            this.toolStripMenuItem2.Text = ">>>";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // aDDTABToolStripMenuItem
            // 
            this.aDDTABToolStripMenuItem.Name = "aDDTABToolStripMenuItem";
            this.aDDTABToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.aDDTABToolStripMenuItem.Text = "ADD PAGE";
            this.aDDTABToolStripMenuItem.Click += new System.EventHandler(this.aDDTABToolStripMenuItem_Click);
            // 
            // rEMOVEPAGEToolStripMenuItem
            // 
            this.rEMOVEPAGEToolStripMenuItem.Name = "rEMOVEPAGEToolStripMenuItem";
            this.rEMOVEPAGEToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.rEMOVEPAGEToolStripMenuItem.Text = "REMOVE PAGE";
            this.rEMOVEPAGEToolStripMenuItem.Click += new System.EventHandler(this.rEMOVEPAGEToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 472);
            this.tabControl1.TabIndex = 1;
            // 
            // webForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 499);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "webForm";
            this.Text = "WEB BROWSER";
            this.Load += new System.EventHandler(this.webForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDDRESSURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem gOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aDDTABToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEMOVEPAGEToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
    }
}