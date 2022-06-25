using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace web_browser1st
{
    public partial class monitorHistoryForm : Form
    {
        public monitorHistoryForm()
        {
            InitializeComponent();
        }

        private void monitorHistoryForm_Load(object sender, EventArgs e)
        {
             // string[] data;
            int count = 0;
            string line = "";
            StreamReader sr;
            if (File.Exists("historyMonitor.txt"))
            {
                sr = new StreamReader("historyMonitor.txt");
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

        private void button1_Click(object sender, EventArgs e)
        {
            WindowForMonitor wq = new WindowForMonitor();
            this.Hide();
            wq.Show();

        }
        }
    }
