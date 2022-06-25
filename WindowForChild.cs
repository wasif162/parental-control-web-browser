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
    public partial class WindowForChild : Form
    {
        public WindowForChild()
        {
            InitializeComponent();
        }
          WebBrowser webTab = null;
        private void btnNewtab_Click(object sender, EventArgs e)
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
        private void BtnSelectmode_Click(object sender, EventArgs e)
        {
             this.Hide();

           userSelection u = new userSelection();
            u.Show();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string[] data;
            int count = 0;
            string line = "";


            StreamReader sr = new StreamReader("Child_Reg.txt");
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

                        //-w indicates thats k configuration registry m likhi gai h jo restart hony k bad bh valid rahegi
                        //-p policy ka name btaaty hn  k konsi use krni h agr policy pehly sy mojood hogi tu just hum uska rule btaty hn
                        //-r rule ka name btata h k hum ye wala rule laga rhy hn 
                        //-n means k block krna h ya allow krna ya deny krna h
                        // -f jo filtering rule apply krhy hn uska format set krwata h  ye sab s critical hota h
                        //-x activate krta h policy
                        //-y disable krta h 
                        //-o ye policy ko hi remove krta h
                        //+ use krty hn bidirectional rule k liye
                        //* means kisi bh ip address ko show krhy hoty hn
                        //0 jo h wo humra apna ip adress show krta h

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
                    h.his(txtUrl);


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btnforward_Click(object sender, EventArgs e)
        {
             webBrowser.GoForward();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
             webBrowser.GoBack();
        }
         void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webBrowser.DocumentTitle;
        }
          public static int a = 0;
        private void WindowForChild_Load(object sender, EventArgs e)
        {
             txtUrl.Show();
           // btnNewtab.Hide();
          
           
            // if (a> 1)
             //{
                // label1.Hide();

                 txtUrl.Text = "https://www.google.com";
                 webBrowser.Navigate("https://www.google.com");
       
        }
          private void txturl_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
               // webBrowser.Navigate( txtUrl.Text );
                webBrowser.Navigate("www." + txtUrl.Text + ".com");

        }
        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnrem_Click(object sender, EventArgs e)
        {
             tabControl.TabPages.Remove(tabControl.SelectedTab); 
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
             History_ChildReg h = new History_ChildReg();
            h.Show();
            this.Hide();
        }

        private void webBrowser_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            userSelection u = new userSelection();
            u.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
