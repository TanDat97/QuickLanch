using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickLaunch
{
    class Function
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray(); // chuỗi thành mảng ký tự
            Array.Reverse(arr); // đảo ngược mảng
            return new string(arr); // trả về chuỗi mới sau khi đảo mảng
        }
        public string GetFileName(string s)
        {
            string name=null;
            int i;
            for (i = s.Length - 5; i >= 0; i--)
            {
                if (s[i] != '\\')
                {
                    name += s[i];
                }
                else break;
            }
            name = ReverseString(name);
            return name;
        }

        //tim trong mang filename co chuoi name khong
        public int cbb_FindApp(string[] filename, string name)
        {
            int a = -1;
            for (int i= 0;i < 2000;i++)
                if(filename[i]==name)
                {
                    a = i;
                    break;
                }
            return a;
        }
        public int[] ListBox_FindApp(string[] filename, string name)
        {
            int[] a=new int[1000];
            int n = 0, i = 0;
            int m = 1;
            foreach(string s in filename)
            {
                if (s == null)
                    break;
                else
                {
                    string s1 = s.ToUpper();
                    string s2 = name.ToUpper();
                    if (s1.IndexOf(s2) == 0)
                    {
                        a[m] = i;
                        n++;
                        m++;  
                    }
                    i++;
                    
                }
                
            }
            a[0] = n;
            if (n == 0)
                a = null;
            return a;
        }

        //xoa chuoi co vi tri index ra khoi chuoi file
        public string[] deleteString(string[] file, int index)
        {
            for (int i = index; i < file.Count() - 1; i++)
                file[i] = file[i + 1]; 
            return file;
        }

        public void InsertionSort(int[] a, int n)
        {
            int x, temp;
            for (int i = 1; i < n; i++)
            {
                x = i - 1; // Bắt đầu tìm x 
                temp = a[i]; // Duyệt ngược từ phải qua, tìm vị trí phù hợp để chèn 
                while (x >= 0 && a[x] > temp)
                {
                    a[x + 1] = a[x];
                    x--;
                }
                a[x + 1] = temp; // Gán vào vị trí x đã tìm
            }
        }
    }
}
