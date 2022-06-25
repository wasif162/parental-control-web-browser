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
    public partial class MonitorUserLog : Form
    {
        public string username, password;
        public MonitorUserLog()
        {
            InitializeComponent();
        }

        private void UserLogBtn_Click(object sender, EventArgs e)
        {
            Log l = new Log();
            l.Montorlogin(UserLogName,UserLogPass);
            this.Hide();
        }

        private void UserLog_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
