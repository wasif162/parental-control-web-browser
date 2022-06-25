using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace web_browser1st
{
    public partial class userSelection : Form
    {

        Mon_UserReg Usm = new Mon_UserReg();

        MonitorUserLog ml = new MonitorUserLog();
        Child_Log_Form CLF = new Child_Log_Form();
        Parent_Reg_Form prF = new Parent_Reg_Form();
        Parent_Log_Form plF = new Parent_Log_Form();

        private Label Heading;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Button MonModeBtn;
        private Button ParentModeBtn;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button button6;
        private Button ChildModeBtn;

        public userSelection()
        {
            InitializeComponent();
        }

        //private void buttonMon_Click(object sender, EventArgs e)
        //{

        //}


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userSelection));
            this.Heading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MonModeBtn = new System.Windows.Forms.Button();
            this.ParentModeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ChildModeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.BackColor = System.Drawing.Color.Transparent;
            this.Heading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Heading.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Heading.Location = new System.Drawing.Point(62, 29);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(222, 35);
            this.Heading.TabIndex = 3;
            this.Heading.Text = "Parental Control Web Browser";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(26, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 55);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(414, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "MONITOR MODE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(724, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "PARENT MODE";
            // 
            // MonModeBtn
            // 
            this.MonModeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MonModeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MonModeBtn.BackgroundImage")));
            this.MonModeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MonModeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonModeBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MonModeBtn.Location = new System.Drawing.Point(418, 202);
            this.MonModeBtn.Name = "MonModeBtn";
            this.MonModeBtn.Size = new System.Drawing.Size(145, 163);
            this.MonModeBtn.TabIndex = 7;
            this.MonModeBtn.UseVisualStyleBackColor = false;
            this.MonModeBtn.Click += new System.EventHandler(this.MonModeBtn_Click);
            // 
            // ParentModeBtn
            // 
            this.ParentModeBtn.BackColor = System.Drawing.Color.Transparent;
            this.ParentModeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ParentModeBtn.BackgroundImage")));
            this.ParentModeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ParentModeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParentModeBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ParentModeBtn.Location = new System.Drawing.Point(728, 168);
            this.ParentModeBtn.Name = "ParentModeBtn";
            this.ParentModeBtn.Size = new System.Drawing.Size(142, 169);
            this.ParentModeBtn.TabIndex = 6;
            this.ParentModeBtn.UseVisualStyleBackColor = false;
            this.ParentModeBtn.Click += new System.EventHandler(this.ParentModeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(95, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "CHILD MODE";
            // 
            // ChildModeBtn
            // 
            this.ChildModeBtn.BackColor = System.Drawing.Color.White;
            this.ChildModeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChildModeBtn.BackgroundImage")));
            this.ChildModeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChildModeBtn.Location = new System.Drawing.Point(85, 168);
            this.ChildModeBtn.Name = "ChildModeBtn";
            this.ChildModeBtn.Size = new System.Drawing.Size(134, 169);
            this.ChildModeBtn.TabIndex = 0;
            this.ChildModeBtn.UseVisualStyleBackColor = false;
            this.ChildModeBtn.Click += new System.EventHandler(this.ChildModeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(313, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome to our Browser";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(401, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "CHOOSE YOUR MODE";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(900, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 39);
            this.button6.TabIndex = 59;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // userSelection
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(977, 510);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MonModeBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.ParentModeBtn);
            this.Controls.Add(this.ChildModeBtn);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USER SELECTION";
            this.Load += new System.EventHandler(this.userSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void Mon_message(DialogResult Con)
        {

            Con = MessageBox.Show("If you want Registration to click yes", "Registration OR Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Con == DialogResult.Yes)
            {

                Usm.Show();

            }
            else if (Con == DialogResult.No)
            {

                ml.Show();
            }

        }

        public void Parent_message(DialogResult Con)
        {

            DialogResult ans = MessageBox.Show("You are not eligible for Registration, so if You want to know ID or Pass contact to Monitor", "====== NOTE ======", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (ans == DialogResult.Yes)
            {

                plF.Show();
            }
            else if (ans == DialogResult.No)
            {
                this.Show();
            } 
            //Con = MessageBox.Show("If you want Registration to click yes", "Registration OR Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (Con == DialogResult.Yes)
            //{
            //    prF.Show();

            //}
            //else if (Con == DialogResult.No)
            //{

          //      plF.Show();
          //  }

        }

        
        private void MonModeBtn_Click(object sender, EventArgs e)
        {
            //chk = 3;
            //this.Hide();
            //Mon_message(DialogResult);


            chk = 1;
            this.Hide();
            DialogResult ans = MessageBox.Show("you Know username and password", "====== NOTE ======", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (ans == DialogResult.Yes)
            {

                ml.Show();
            }
            else if (ans == DialogResult.No)
            {
                this.Show();
            } 


        }

        private void ParentModeBtn_Click(object sender, EventArgs e)
        {
            chk = 2;
            this.Hide();
            Parent_message(DialogResult);
            WindowsForParent a = new WindowsForParent();
            //            if (a.btnGo_Click=true)
            //            {String path = @"C:\Windows\System32\drivers\etc\hosts";
            //StreamWriter sw = new StreamWriter(path, true);
            //String sitetoblock = "\n 127.0.0.1 stackoverflow.com";
            //sw.Write(sitetoblock);
            //sw.Close();
            //MessageBox.Show("Acessing Blocked sites");

            //            }
        }

        public void ChildModeBtn_Click(object sender, EventArgs e)
        {
            chk = 1;
            this.Hide();
            DialogResult ans = MessageBox.Show("You are not eligible for Registration, so if You want to know ID or Pass contact to Monitor", "====== NOTE ======", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (ans == DialogResult.Yes)
            {
               
                CLF.Show();
            }
            else if (ans == DialogResult.No)
            {
                this.Show();
            } 
            //appwebbrowser a = new appwebbrowser();
            //a.Hide();
            //userSelection u = new userSelection();
            //u.Hide();
            //a.Show();

            //Child mode prr offensive websites ka kaam blocking and unblocking donon 

            //  System.ServiceProcess.ServiceController scPAServ = new System.ServiceProcess.ServiceController("PolicyAgent"); //IPSec

            //if (scPAServ.Status != System.ServiceProcess.ServiceControllerStatus.Running)
            //{
            //    scPAServ.Start(); //Start If Not Running
            //}
            //string[] strCommands =  { @"-w REG -p ""Firewall"" -r ""Block All"" -f *:*:*+*:*:* -n BLOCK -x" ,
            //                @"-w REG -p ""Firewall"" -r ""Allow LAN"" -f 0:*:*+192.168.10.*:*:* -n PASS -x" ,
            //                @"-w REG -p ""Firewall"" -r ""DNS"" -f 0:*:UDP+223.211.190.23:53:UDP 0:*:UDP+223.211.190.24:53:UDP 0:*:TCP+223.211.190.23:53:TCP 0:*:TCP+223.211.190.24:53:TCP -n PASS -x" ,
            //                @"-w REG -p ""Firewall"" -r ""POP3"" -f 0:*:TCP+*:110:TCP -n PASS -x" ,
            //                @"-w REG -p ""Firewall"" -r ""POP3S"" -f 0:*:TCP+*:995:TCP -n PASS -x" ,
            //               @"-w REG -p ""Firewall"" -r ""FTP Control"" -f 0:*:TCP+*:21:TCP -n PASS -x" ,
            //                @"-w REG -p ""Firewall"" -r ""FTP Data"" -f 0:*:TCP+*:20:TCP -n PASS -x" ,
            //                @"-w REG -p ""Firewall"" -r ""IMAP"" -f 0:*:TCP+*:143:TCP -n PASS -x" ,
            //                @"-w REG -p ""Firewall"" -r ""HTTP"" -f 0:*:TCP+*:80:TCP -n PASS -x" ,
            //                @"-w REG -p ""Firewall"" -r ""HTTPS"" -f 0:*:TCP+*:443:TCP -n BLOCK -x" ,
            //                @"-w REG -p ""Firewall"" -r ""PROXY"" -f 0:*:TCP+*:8080:TCP 0:*:TCP+*:3128:TCP 0:*:TCP+*:8081:*:TCP 0:*:TCP+*:8000:TCP -n BLOCK -x"};

            //for (int i = 0; i < strCommands.Length; i++) //Loop through each Command String
            //{
            //    ProcessStartInfo psiStart = new ProcessStartInfo(); //Process To Start

            //    psiStart.CreateNoWindow = true; //Invisible

            //    psiStart.FileName = Directory.GetParent(Assembly.GetExecutingAssembly().Location) + "\\ipseccmd.exe"; //IPSEC

            //    psiStart.Arguments = strCommands[i]; //Break Command Strings Apart

            //    psiStart.WindowStyle = ProcessWindowStyle.Hidden; //Invisible

            //    Process p = System.Diagnostics.Process.Start(psiStart); //Start Process To Block Internet Connection
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.ServiceProcess.ServiceController scPAServ = new System.ServiceProcess.ServiceController("PolicyAgent"); //IPSec


            if (scPAServ.Status != System.ServiceProcess.ServiceControllerStatus.Running) //If Not Running
            {
                scPAServ.Start();
            }
            string strCommands = @"-w REG -p ""Firewall"" -r ""Block All"" -f *:*:*+*:*:* -n BLOCK -y"; //Commands To Send

            ProcessStartInfo psiStart = new ProcessStartInfo(); //Process To Start

            psiStart.CreateNoWindow = true; //Invisible

            psiStart.FileName = Directory.GetParent(Assembly.GetExecutingAssembly().Location) + "\\ipseccmd.exe"; //IPSEC

            psiStart.Arguments = strCommands; //Give Command String As Argument

            psiStart.WindowStyle = ProcessWindowStyle.Hidden;  //Invisible

            Process p = System.Diagnostics.Process.Start(psiStart);  //Start Process To Stop Internet Connection
        }
        public static int chk = 0;

        private void userSelection_Load(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




