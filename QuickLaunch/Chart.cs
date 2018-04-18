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
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
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

            int x, temp, n = i;
            string s;
            for (i = 1; i < n; i++)
            {
                x = i - 1; // Bắt đầu tìm x 
                temp = count[i]; // Duyệt ngược từ phải qua, tìm vị trí phù hợp để chèn 
                s = file[i];
                while (x >= 0 && count[x] < temp)
                {
                    count[x + 1] = count[x];
                    file[x + 1] = file[x];
                    x--;
                }
                count[x + 1] = temp; // Gán vào vị trí x đã tìm\
                file[x + 1] = s;
            }

            int sum = 0, other = 100;   //  ung dung khac = 100;
            int[] tile = new int[6];

            for (i = 0; i < n; i++)
                sum += count[i];
            
            for (i = 0; i < n; i++)
            {
                 tile[i] = (int)1.0 * count[i] * 100 / sum;
                 other -= tile[i];
                 chartTile.Series["TiLe"].Points.AddXY(file[i], tile[i]);
                 if (i == 5)
                 {
                    chartTile.Series["TiLe"].Points.AddXY("Ứng dụng khác", other);
                     break;
                 }   
            }
           
            //if (n > 6) 
            //    chartTile.Series["TiLe"].Points.AddXY("Ứng dụng khác", other); 
        }
    }
}
