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
    public partial class Delete : Form
    {
        private string[] filename = new string[2000];
        private string[] filepath = new string[2000];
        public Delete()
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
                i = 0;
                using (StreamReader sr = new StreamReader("filepath.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        filepath[i] = line;
                        i++;
                    }
                }
                int j = 0;
                foreach (string s in filename)
                {
                    deleteApp.Items.Add(s);
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

        private void deleteApp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("filename.txt"))
            {
                for(int i = 0; i<deleteApp.Items.Count;i++)
                {
                    sw.WriteLine(filename[i]);
                }
            }
            using (StreamWriter sw = new StreamWriter("filepath.txt"))
            {
                for (int i = 0; i < deleteApp.Items.Count; i++)
                {
                    sw.WriteLine(filepath[i]);
                }
            }
            this.Dispose();
        }

        private void Delete_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Data d = new Data();
            d.ShowDialog();
        }

        private void deleteApp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function a = new Function();
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.B))
            {
                filename = a.deleteString(filename, deleteApp.SelectedIndex);
                filepath = a.deleteString(filepath, deleteApp.SelectedIndex);
                deleteApp.Items.RemoveAt(deleteApp.SelectedIndex);
            }
        }
    }
}