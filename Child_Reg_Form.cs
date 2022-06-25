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
    public partial class Child_Reg_Form : Form
    {
        public Child_Reg_Form()
        {
            InitializeComponent();
        }

        private void UserLogBtn_Click(object sender, EventArgs e)
        {
            Regestration r = new Regestration();
            r.ChildReg(UserLogName,UserLogPass);
            this.Hide();
        }

        private void Child_Reg_Form_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
