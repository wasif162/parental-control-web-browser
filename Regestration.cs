using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace web_browser1st
{
    class Regestration
    {



        public void MonitorReg(TextBox name, TextBox pass)
        {
            StreamWriter sw = new StreamWriter("monitor_Reg.txt",true);
            sw.WriteLine(name.Text + "," + pass.Text);
            if (name.Text=="" || pass.Text=="")
            {

                MessageBox.Show("May be name or pass not entered!! please fulfil the conditon");
               // MonitorReg(name, pass);
                sw.Close();
            }
            else
            {
              //  MonitorReg(name,pass);
                sw.Close();
                MessageBox.Show("regesterd!!!");
            }
           

        }

        public void ParentReg(TextBox name, TextBox pass)
        {
            StreamWriter sw = new StreamWriter("Parent_Reg.txt",true);
            sw.WriteLine(name.Text + "," + pass.Text);
            if (name.Text == "" || pass.Text == "")
            {

                MessageBox.Show("May be name or pass not entered!! please fulfil the conditon");
                sw.Close();
            }
            else
            {
               // ParentReg(name, pass);
                sw.Close();
                MessageBox.Show("regesterd!!!");
            }


        }
       
        public void ChildReg(TextBox name, TextBox pass)
        {
            StreamWriter sw1 = new StreamWriter("Child_Reg.txt",true);
            
          
            if (name.Text == "" || pass.Text == "")
            {
//
                MessageBox.Show("May be name or pass not entered!! please fulfil the conditon");
                sw1.Close();
            }
            else
            {
                sw1.WriteLine(name.Text + "," + pass.Text);
                //ChildReg(name, pass);
                sw1.Close();
                MessageBox.Show("regesterd!!!");
            }


        }
    }
}
