using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using web_browser1st.Properties;

namespace web_browser1st
{
    class Log
    {
        MonitorUserLog mul = new MonitorUserLog();
        Parent_Log_Form plF = new Parent_Log_Form();

        public static string[] data;
        int count = 0;
        string line = "";
        public void Montorlogin(TextBox name, TextBox pass)
        {
            StreamReader sr = new StreamReader("monitor_Reg.txt");
            // line = sr.ReadLine();
            while (count < 1)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    data = line.Split(',');
                    if (data[0] == name.Text && data[1] == pass.Text)
                    {
                        MessageBox.Show("succesfull!!!");
                        //mul.Hide();
                        WindowForMonitor a = new WindowForMonitor();
                        a.Show();

                        break;

                    }
                }
                else
                {
                    count++;
                    sr.Close();
                    MessageBox.Show("not match");

                }


            }
        }

        public void parent_Login(TextBox name, TextBox pass)
        {
            StreamReader sr = new StreamReader("Parent_Reg.txt");
            // line = sr.ReadLine();
            while (count < 1)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    data = line.Split(',');
                    if (data[0] == name.Text && data[1] == pass.Text)
                    {
                        MessageBox.Show("succesfull!!!");
                        //mul.Hide();
                        WindowsForParent a = new WindowsForParent();
                        a.Show();



                        break;

                    }
                }
                else
                {
                    count++;
                    sr.Close();
                    MessageBox.Show("not match");

                }


            }
        }



        public void cHILD_Log(TextBox name, TextBox pass)
        {
            StreamReader sr = new StreamReader("Child_Reg.txt");
            // line = sr.ReadLine();
            while (count < 1)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    data = line.Split(',');
                    if (data[0] == name.Text && data[1] == pass.Text)
                    {
                        MessageBox.Show("sussesfull!!!");
                        //mul.Hide();
                        WindowForChild w = new WindowForChild();
                       // appwebbrowser a = new appwebbrowser();
                        w.Show();
                        break;

                    }
                }
                else
                {
                    count++;
                    sr.Close();
                    MessageBox.Show("not match");

                }


            }
        }

        public void Montorlogin_For_child_reg(TextBox name, TextBox pass)
        {
            StreamReader sr = new StreamReader("monitor_Reg.txt");
            while (count < 1)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    data = line.Split(',');
                    if (data[0] == name.Text && data[1] == pass.Text)
                    {
                        MessageBox.Show("sussesfull!!!");
                        Child_Reg_Form crF = new Child_Reg_Form();
                        crF.Show();


                        break;

                    }
                }
                else
                {
                    count++;
                    sr.Close();
                    MessageBox.Show("not match");

                }


            }
        }
        public  void Montorlogin_For_Delete(TextBox name, TextBox pass, ListBox lb )
        {
            StreamReader sr = new StreamReader("monitor_Reg.txt");
            while (count < 1)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    data = line.Split(',');
                    if (data[0] == name.Text && data[1] == pass.Text)
                    {
                        MessageBox.Show("sussesfull!!!");
                        
                        

                        break;

                    }
                }
                else
                {
                    count++;
                    sr.Close();
                    MessageBox.Show("not match");

                }


            }
        }
    }


        //    public static  void Parentloginn(TextBox name, TextBox pass)
        //{
        //    StreamReader sr = new StreamReader("Parent_Reg.txt");
        //   // line = sr.ReadLine();u
        //    while (count < 1)
        //    {
        //        line = sr.ReadLine();
        //        if (line != null)
        //        {
        //            data = line.Split(',');
        //            if (data[0] == name.Text && data[1] == pass.Text)
        //            {
                    
        //                MessageBox.Show("sussesfull!!!");

        //                //plF.Close();
                      
        //                appwebbrowser a = new appwebbrowser();
        //                a.Show();
        //              //  obj.Hide();
                       
        //                break;
                       
        //            }
        //        }
        //        else
        //        {
        //            count++;
        //            sr.Close();
                    
        //            MessageBox.Show("not match");
        //        }
                

        //    }
        //}



            //public void Childlogin(TextBox name, TextBox pass)
            //{
            //    StreamReader sr = new StreamReader("Child_Reg.txt");
            //    // line = sr.ReadLine();
            //    while (count < 1)
            //    {
            //        line = sr.ReadLine();
            //        if (line != null)
            //        {
            //            data = line.Split(',');
            //            if (data[0] == name.Text && data[1] == pass.Text)
            //            {
            //                MessageBox.Show("sussesfull!!!");

            //                appwebbrowser a = new appwebbrowser();
            //                a.Show();


            //                break;

            //            }
            //        }
            //        else
            //        {
            //            count++;
            //            sr.Close();
            //            MessageBox.Show("not match");
            //        }


            //    }
            //}

    }

