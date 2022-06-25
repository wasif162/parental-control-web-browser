using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_browser1st
{
    public partial class ParentMonitorChild : Form
    {
        public ParentMonitorChild()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsForParent we = new WindowsForParent();
            this.Hide();
            we.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ParentMonitorChild_Load(object sender, EventArgs e)
        {
            // string[] data;
            int count = 0;
            string line = "";
            StreamReader sr;
            if (File.Exists("History.txt"))
            {
                sr = new StreamReader("History.txt");
                while (count < 1)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {

                        listBox1.Items.Add(line.ToString());

                    }
                    else
                    {
                        count++;
                        sr.Close();
                        //MessageBox.Show("not match");
                    }


                }


            }
        }

        private void Heading_Click(object sender, EventArgs e)
        {

        }
    }
}
