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
    public partial class Child_Log_Form : Form
    {
        public Child_Log_Form()
        {
            InitializeComponent();
        }

        private void UserLogBtn_Click(object sender, EventArgs e)
        {
            Log l = new Log();
            l.cHILD_Log(UserLogName, UserLogPass);
            this.Hide();
        }

        private void Child_Log_Form_Load(object sender, EventArgs e)
        {

        }

        private void MonLogName_Click(object sender, EventArgs e)
        {

        }

        private void MonLogPass_Click(object sender, EventArgs e)
        {

        }
    }
}
