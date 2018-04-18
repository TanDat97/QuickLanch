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

namespace QuickLaunch
{
    public partial class AvailableApp : Form
    {
        private string[] filename = new string[2000];

        public AvailableApp()
        {
            InitializeComponent();
            try
            {
                int i = 0;
                using (StreamReader sr = new StreamReader("filename.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        filename[i] = line;
                        i++;
                    }
                }
                int j = 0;
                foreach(string s in filename)
                {
                    txtApp.Text += s + Environment.NewLine;
                    j++;
                    if (j >= i) break;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Cannot open file", "Message");
                this.Dispose();
            }
        }
        public string[] GetFileNameList()
        {
            return filename;
        }
        private void txtApp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
