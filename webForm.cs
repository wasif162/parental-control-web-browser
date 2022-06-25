using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_browser1st
{
    public partial class webForm : Form
    {
        public webForm()
        {
            InitializeComponent();
        }

        public string ThetabControl1
        {
            get { return tabControl1.Text; }
            set { tabControl1.Text = value; }
        }

        History_ChildReg hcr = new History_ChildReg();
        
        WebBrowser web = new WebBrowser();
        int i = 0;
        private void webForm_Load(object sender, EventArgs e)
        {

            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted+= web_DocumentCompleted;
            tabControl1.TabPages.Add("NEW TAB");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);

            i += 1;


        }

        private void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;

        }

        private void gOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripComboBox1.Text);
            if (!toolStripComboBox1.Items.Contains(toolStripComboBox1.Text))
            {
                toolStripComboBox1.Items.Add(toolStripComboBox1.Text);
            }
          hcr.ListViewText = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Document.Url.AbsoluteUri;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
        }

        private void aDDTABToolStripMenuItem_Click(object sender, EventArgs e)
        {
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += web_DocumentCompleted;
            tabControl1.TabPages.Add("NEW TAB");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);

            i += 1;

        }

        private void rEMOVEPAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count-1 > 0)
            {
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i -= 1;
            }
        }

        private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripComboBox1.Text);
                if (!toolStripComboBox1.Items.Contains(toolStripComboBox1.Text))
                {
                    toolStripComboBox1.Items.Add(toolStripComboBox1.Text);
                }
            }
        }



        //internal void ThetabControl1(string[] breakLine)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
