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
    public partial class Monitor_For_child_Reg : Form
    {
        public Monitor_For_child_Reg()
        {
            InitializeComponent();
        }

        private void UserLogBtn_Click(object sender, EventArgs e)
        {
            Log l = new Log();
            l.Montorlogin_For_child_reg(UserLogName,UserLogPass);
            this.Hide();
          
        }

        private void Monitor_For_child_Reg_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
