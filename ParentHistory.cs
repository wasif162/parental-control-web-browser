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
    public partial class ParentHistory : Form
    {
       // appwebbrowser web = new appwebbrowser();
        public ParentHistory()
        {
            InitializeComponent();
        }

        private void ParentHistory_Load(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ClearHBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (File.Exists("Histroyparent.txt"))
            {
                StreamWriter sw = new StreamWriter("Histroyparent.txt");

            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

            History_ChildReg h = new History_ChildReg();
            h.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowsForParent we = new WindowsForParent();
            this.Hide();
            we.Show();
        }
    }
}