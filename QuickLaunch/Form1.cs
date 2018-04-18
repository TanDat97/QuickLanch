using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace QuickLaunch
{
    public partial class QuickLaunch : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string sClassName, string sAppName);
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnRegisterHotKey(IntPtr hWnd, int id);

        private string[] filename = new string[2000];
        private string[] filepath = new string[2000];
        private string name;
        private string path;
        private bool kt = false;

        KeyboardHook hook = new KeyboardHook();
        public QuickLaunch()
        {
            InitializeComponent();
            listApps.Hide();
            using (StreamReader sr = new StreamReader("filename.txt"))
            {
                string line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    filename[i] = line;
                    i++;
                }
            }
            using (StreamReader sr = new StreamReader("filepath.txt"))
            {
                string line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    filepath[i] = line;
                    i++;
                }
            }
            
            //this.WindowState = FormWindowState.Minimized;
        }

        private void QuickLaunch_Load(object sender, EventArgs e)
        {
            
        }
        
        private void showCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (d != null)
            //    d.Dispose();
            //this.Show();
            //this.WindowState = FormWindowState.Normal;
            Application.Restart();
        }
        private void scanToBuildDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data d;
            this.Hide();
            d = new Data();
            d.ShowDialog();
        }
        private void viewStatitisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chart d;
            this.Hide();
            d = new Chart();
            d.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void QuickLaunch_Move(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Minimized)
            {
                this.Hide();
            }
            
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Application.Restart();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"D:\game\cotuong.exe");
            try
            {  
                System.Diagnostics.Process.Start(path);

                int i = 0;
                string[] file = new string[2000];
                int[] count = new int[2000];
                for (i = 0; i < 2000; i++)
                    count[i] = 0;

                i = 0;
                using (StreamReader sr = new StreamReader("file.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        file[i++] = line;
                }
                i = 0;
                using (StreamReader sr = new StreamReader("count.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        count[i++] = int.Parse(line);
                }

                Function a = new Function();
                name = a.GetFileName(path);
                if (a.cbb_FindApp(file, name) != -1)  // neu name co trong file[]
                    count[a.cbb_FindApp(file, name)] += 1;  //  tang 1 don vi
                else
                {
                    file[i] = name;
                    count[i++] = 1;  // gan bang 1
                }
                int j = 0;
                using (StreamWriter sw = new StreamWriter("file.txt"))// ghi lai vao file
                {
                    foreach (string s in file)
                    {    
                        sw.WriteLine(s);
                        j++;
                        if (j == i)
                            break;
                    }
                }
                using (StreamWriter sw = new StreamWriter("count.txt"))
                {
                    foreach (int s in count)
                    {
                        if (s == 0)
                            break;
                        sw.WriteLine(s);
                    }
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Can not open", "Eror");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "All files (*.*)|*.*";
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                cbbApp.Text = oFile.FileName;
                //app.Text = oFile.FileName.Substring(oFile.FileName.LastIndexOf("\\") + 1);
                path = oFile.FileName;
                btnOK.Focus();
            }
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            try
            {
                AvailableApp a = new AvailableApp();
                a.ShowDialog();
            }
            catch
            {     
            }
        }

        private void cbbApp_KeyPress(object sender, KeyPressEventArgs e)
        { 
            
        }
        private void cbbApp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK.PerformClick();
            if (e.KeyCode == Keys.Down)
            {
                listApps.SetSelected(0, true);
                listApps.Focus();
            }
            if(e.KeyCode==Keys.Up)
            {
                int a = listApps.Items.Count - 1;
                listApps.SetSelected(a, true);
                listApps.Focus();
            }
        }
        private void cbbApp_KeyUp(object sender, KeyEventArgs e)
        {
            path = cbbApp.Text;
            Function a = new Function();
            int[] kq = new int[1000];

            if (a.cbb_FindApp(filename, path) != -1)
                path = filepath[a.cbb_FindApp(filename, path)];
            else
            if (a.ListBox_FindApp(filename, path) != null)
            {
                kt = true;
                listApps.Items.Clear();
                kq = a.ListBox_FindApp(filename, path);
                for (int i = 1; i <= kq[0]; i++)
                    listApps.Items.Add(filename[kq[i]]);
            }
            else kt = false;
            if ((cbbApp.Text != "") && (kt == true))
            {
                listApps.Show();
            }
            else
                listApps.Hide();
        }

        private void listApps_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function a = new Function();
            path = filepath[a.cbb_FindApp(filename, listApps.SelectedItem.ToString())];
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }

        private void listApps_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Down) && (listApps.SelectedIndex == listApps.Items.Count - 1))
            {
                cbbApp.Focus();
            }
            if ((e.KeyCode == Keys.Up) && (listApps.SelectedIndex == 0))
            {
                cbbApp.Focus();
            }
        }
    }
}
