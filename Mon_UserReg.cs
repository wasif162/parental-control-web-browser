using System;
using System.IO;
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
    public partial class Mon_UserReg : Form
    {
        
        public Mon_UserReg()
        {
            InitializeComponent();
        }

        private void UserRegBtn_Click(object sender, EventArgs e)
        {

            Regestration reg = new Regestration();
            reg.MonitorReg(UserName, UserPass);
            this.Hide();
            MonitorUserLog Ul = new MonitorUserLog();
            Ul.Show();
            
           
            
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
