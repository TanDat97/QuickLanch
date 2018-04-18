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
using Microsoft.Win32;

namespace QuickLaunch
{
    public partial class Data : Form
    {
        private string folderPath;
        public Data()
        {
            InitializeComponent();
        }

        private void Data_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    folderPath = fbd.SelectedPath;
                    //System.Windows.Forms.MessageBox.Show("Select Folder: " + folderPath, "Message");
                }
            }
            int i = 0;
            try
            {
               
                Function a = new Function();
                string[] files = Directory.GetFiles(folderPath, "*.exe", SearchOption.AllDirectories);
                int sum1 = 0, sum2 = Directory.GetFiles(folderPath, "*.exe", SearchOption.AllDirectories).Count();
        
                using (StreamReader sr = new StreamReader("filename.txt")) 
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        sum1++;
                }
                
                string[] filename = new string[sum1 + sum2];
                string[] filepath = new string[sum1 + sum2]; // tong so luong ban dau va folder moi duoc chon them

                i = 0;
                using (StreamReader sr = new StreamReader("filename.txt"))  // doc file name
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        filename[i] = line;
                        i++;
                    }
                }
                i = 0;
                using (StreamReader sr = new StreamReader("filepath.txt")) //doc file path
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        filepath[i] = line;
                        i++;
                    }
                }

                foreach (string file in files)
                {
                    filepath[i] = file;
                    filename[i] = a.GetFileName(file);
                    i++;
                }

                using (StreamWriter sw = new StreamWriter("filename.txt"))// ghi lai vao file
                {
                   
                    foreach (string s in filename)
                    {
                        sw.WriteLine(s);
                        if (s == null)
                            break;
                    }
                }
                using (StreamWriter sw = new StreamWriter("filepath.txt"))
                {
                    foreach (string s in filepath)
                    {
                        sw.WriteLine(s);
                        if (s == null)
                            break;
                    }
                }
                //FileStream F = new FileStream("filename.txt", FileMode.Append, FileAccess.Write);

                System.Windows.Forms.MessageBox.Show("Load file succes" , "Message");
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Eror", "Message");
            }
            folderPath = null;
        }

      
        private void btnSelectfile_Click(object sender, EventArgs e)
        {
            try
            {
                Function a = new Function();
                OpenFileDialog oFile = new OpenFileDialog();
                string name = null, path = null;
                int sum1 = 0, i = 0;
                oFile.Filter = "*.exe|*.exe|All files (*.*)|*.*";
                if (oFile.ShowDialog() == DialogResult.OK)
                {
                    //name = oFile.FileName.Substring(oFile.FileName.LastIndexOf("\\") + 1);
                    name = a.GetFileName(oFile.FileName);
                    path = oFile.FileName;
                }

                using (StreamReader sr = new StreamReader("filename.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        sum1++;
                }

                string[] filename = new string[sum1 + 1];
                string[] filepath = new string[sum1 + 1]; // tong so luong ban dau va folder moi duoc chon them

                i = 0;
                using (StreamReader sr = new StreamReader("filename.txt"))  // doc file name
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        filename[i] = line;
                        i++;
                    }
                }
                i = 0;
                using (StreamReader sr = new StreamReader("filepath.txt")) //doc file path
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        filepath[i] = line;
                        i++;
                    }
                }

                filepath[sum1] = path;
                filename[sum1] = name;

                using (StreamWriter sw = new StreamWriter("filename.txt"))// ghi lai vao file
                {

                    foreach (string s in filename)
                    {
                        sw.WriteLine(s);
                    }
                }
                using (StreamWriter sw = new StreamWriter("filepath.txt"))
                {
                    foreach (string s in filepath)
                    {
                        sw.WriteLine(s);
                    }
                }
                System.Windows.Forms.MessageBox.Show("Select file: " + path, "Message");
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Eror", "Message");
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Delete d = new Delete();
            d.ShowDialog();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("filename.txt"))
            {
            }
            using (StreamWriter sw = new StreamWriter("filepath.txt"))
            {
            }
            System.Windows.Forms.MessageBox.Show("Delete all Database", "Message");
        }

       
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Restart();
        }

        private void Data_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("filename.txt"))
            {
            }
            using (StreamWriter sw = new StreamWriter("filepath.txt"))
            {
            }

            try
            {
                string[] filename = new string[1000];
                string[] filepath = new string[1000];
                int i = 0;
                //string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
                string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
                using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
                {
                    foreach (string skName in rk.GetSubKeyNames())
                    {
                        using (RegistryKey sk = rk.OpenSubKey(skName))
                        {
                            try
                            {    
                                var displayName = sk.GetValue("DisplayName");
                                //var path = sk.GetValue();
                                //string path;
                                var size = sk.GetValue("EstimatedSize");
                                //ListViewItem item;
                                if (displayName != null)
                                {
                                    //if (size != null)
                                    //    item = new ListViewItem(new string[] {displayName.ToString(), 
                                    //                   size.ToString()});
                                    //else
                                    //    item = new ListViewItem(new string[] { displayName.ToString() });
                                    filepath[i] = "" + sk.GetValue("InstallLocation") + sk.GetValue("Name");
                                    filename[i++] =  displayName.ToString();
                                }
                            }
                            catch (Exception ex)
                            { }
                        }
                    }

                    using (StreamWriter sw = new StreamWriter("filename.txt"))// ghi lai vao file
                    {
                        foreach (string s in filename)
                        {
                            sw.WriteLine(s);
                            if (s == null)
                                break;
                        }
                    }
                    using (StreamWriter sw = new StreamWriter("filepath.txt"))// ghi lai vao file
                    {
                        foreach (string s in filepath)
                        {
                            sw.WriteLine(s);
                            if (s == null)
                                break;
                        }
                    }
                }
                System.Windows.Forms.MessageBox.Show("Load Installed App Successfull", "Message");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Cannot Load Installed App", "Eror");
            }
        }

     
    }
}
