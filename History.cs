using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace web_browser1st
{
    class History
    {
        public void his(TextBox tb)
        {
            StreamWriter sw = new StreamWriter("History.txt",true);
            sw.WriteLine(tb.Text);
            sw.Close();
        }
        public void parent(TextBox tb)
        {
            StreamWriter sw = new StreamWriter("Histroyparent.txt", true);
            sw.WriteLine(tb.Text);
            sw.Close();
        }
        public void monitor(TextBox tb)
        {
            StreamWriter sw = new StreamWriter("historyMonitor.txt", true);
            sw.WriteLine(tb.Text);
            sw.Close();
        }
    }
}
