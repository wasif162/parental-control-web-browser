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
    public partial class AdminParentHistory : Form
    {
        public AdminParentHistory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowForMonitor we = new WindowForMonitor();
            this.Hide();
            we.Show();
        }

        private void AdminParentHistory_Load(object sender, EventArgs e)
        {
            int count = 0;
            string line = "";
            StreamReader sr;
            if (File.Exists("Histroyparent.txt"))
            {
                sr = new StreamReader("Histroyparent.txt");
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

                    }
                }
            }
        }
    }
}