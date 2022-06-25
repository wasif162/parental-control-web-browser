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
    public partial class Parent_Reg_Form : Form
    {
        public Parent_Reg_Form()
        {
            InitializeComponent();
        }

        private void UserLogBtn_Click(object sender, EventArgs e)
        {
            Regestration reg = new Regestration();
            reg.ParentReg(UserLogName, UserLogPass);
            this.Hide();
        }

        private void Parent_Reg_Form_Load(object sender, EventArgs e)
        {

        }

        private void Heading_Click(object sender, EventArgs e)
        {

        }

        private void UserLogPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserLogName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MonLogPass_Click(object sender, EventArgs e)
        {

        }

        private void MonLogName_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
