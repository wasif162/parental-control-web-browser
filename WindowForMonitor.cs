using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_browser1st
{
    public partial class WindowForMonitor : Form
    {
        public WindowForMonitor()
        {
            InitializeComponent();
        }

        private void WindowForMonitor_Load(object sender, EventArgs e)
        {
            txtUrl.Show();
            // btnNewtab.Hide();


            // if (a> 1)
            //{
            // label1.Hide();

            txtUrl.Text = "https://www.google.com";
            webBrowser.Navigate("https://www.google.com");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnforward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string[] data;
            int count = 0;
            string line = "";


            StreamReader sr = new StreamReader("Monitor_Reg.txt");
            // line = sr.ReadLine();
            while (count < 1)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    data = line.Split(',');
                    if (data[0] == Log.data[0])
                    {


                        System.ServiceProcess.ServiceController scPAServ = new System.ServiceProcess.ServiceController("PolicyAgent"); //IPSec

                        if (scPAServ.Status != System.ServiceProcess.ServiceControllerStatus.Running)
                        {
                            scPAServ.Start(); //Start If Not Running
                        }
                        string[] strCommands =  { @"-w REG -p ""Firewall"" -r ""Block All"" -f *:*:*+*:*:* -n BLOCK -x" ,
                            @"-w REG -p ""Firewall"" -r ""Allow LAN"" -f 0:*:*+192.168.10.*:*:* -n PASS -x" ,
                            @"-w REG -p ""Firewall"" -r ""POP3"" -f 0:*:TCP+*:110:TCP -n PASS -x" ,
                            @"-w REG -p ""Firewall"" -r ""POP3S"" -f 0:*:TCP+*:995:TCP -n PASS -x" ,
                            @"-w REG -p ""Firewall"" -r ""FTP Control"" -f 0:*:TCP+*:21:TCP -n PASS -x" ,
                            @"-w REG -p ""Firewall"" -r ""FTP Data"" -f 0:*:TCP+*:20:TCP -n PASS -x" ,
                            @"-w REG -p ""Firewall"" -r ""IMAP"" -f 0:*:TCP+*:143:TCP -n PASS -x" ,
                            @"-w REG -p ""Firewall"" -r ""HTTP"" -f 0:*:TCP+*:80:TCP -n PASS -x" ,
                            @"-w REG -p ""Firewall"" -r ""DNS"" -f 0:*:UDP+223.211.190.23:53:UDP 0:*:UDP+223.211.190.24:53:UDP 0:*:TCP+223.211.190.23:53:TCP 0:*:TCP+223.211.190.24:53:TCP -n PASS -x" ,
                            @"-w REG -p ""Firewall"" -r ""HTTPS"" -f 0:*:TCP+*:443:TCP -n BLOCK -x" ,
                            @"-w REG -p ""Firewall"" -r ""PROXY"" -f 0:*:TCP+*:8080:TCP 0:*:TCP+*:3128:TCP 0:*:TCP+*:8081:*:TCP 0:*:TCP+*:8000:TCP -n BLOCK -x"};

                        for (int i = 0; i < strCommands.Length; i++) //Loop through each Command String
                        {
                            ProcessStartInfo psiStart = new ProcessStartInfo(); //Process To Start

                            psiStart.CreateNoWindow = true; //Invisible

                            psiStart.FileName = Directory.GetParent(Assembly.GetExecutingAssembly().Location) + "\\ipseccmd.exe"; //IPSEC

                            psiStart.Arguments = strCommands[i]; //Break Command Strings Apart

                            psiStart.WindowStyle = ProcessWindowStyle.Hidden; //Invisible

                            //   Process p = System.Diagnostics.Process.Start(psiStart); //Start Process To Block Internet Connection

                            break;

                        }
                    }
                    else
                    {
                        count++;
                        sr.Close();
                        //  MessageBox.Show("not match");
                    }
                    WebBrowser web = tabControl.SelectedTab.Controls[1] as WebBrowser;
                    if (web != null)
                        web.Navigate("www." + txtUrl.Text + ".com");
                    web.Navigate(txtUrl.Text);

                    History h = new History();
                    h.monitor(txtUrl);


                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminChildHistory h = new AdminChildHistory();
            this.Hide();
            h.Show();
        }

        private void btnrem_Click(object sender, EventArgs e)
        {
            AdminParentHistory p = new AdminParentHistory();
            this.Hide();
            p.Show();
        }

        private void btnNewtab_Click(object sender, EventArgs e)
        {
            Child_Reg_Form crf = new Child_Reg_Form();
            crf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Parent_Reg_Form prf = new Parent_Reg_Form();
            prf.Show();

        }
        WebBrowser webTab = null;
        private void button2_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("https://www.google.com");
            webTab.DocumentCompleted += webTab_DocumentCompleted;
        }
        void webTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webTab.DocumentTitle;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }

        private void BtnSelectmode_Click(object sender, EventArgs e)
        {
            this.Hide();

            userSelection u = new userSelection();
            u.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            monitorHistoryForm mm = new monitorHistoryForm();
            this.Hide();
            mm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}