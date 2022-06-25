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
    public partial class History_ChildReg : Form
    {
      //  appwebbrowser web = new appwebbrowser();
        public History_ChildReg()
        {
            InitializeComponent();
        }



        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // appwebbrowser a = new appwebbrowser();


        }

        //public string ListViewText
        //{
        //    get { return listView1.Text; }
        //    set { listView1.Text = value; }
        //}

        private void OpenLinkBtn_Click(object sender, EventArgs e)
        {
            //string[] breakLine = ListViewText.Split(' ');
            //int n = 0;
            //if (n >= 0)
            //{

            //    n++;
            //    for (int i = 1; i <= n; i++)
            //    {

            //        // web.ThetabControl1(breakLine);   
            //    }
            //}

        }

        private void OpenLinkBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void History_ChildReg_Load(object sender, EventArgs e)
        {
           // string[] data;
            int count = 0;
            string line = "";
            StreamReader sr;
            if (File.Exists("History.txt"))
            {
                 sr= new StreamReader("History.txt");
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

        private void ClearHBtn_Click(object sender, EventArgs e)
        {
          

        



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Heading_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowForChild wc = new WindowForChild();
            this.Hide();
            wc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowForChild wc = new WindowForChild();
            this.Hide();
            wc.Show();
        }
    }
}
