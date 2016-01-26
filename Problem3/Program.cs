using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Problem3
{
    class Program
    {
        
        static bool IsPrime(string s)
        {
            int x = int.Parse(s);
            int cnt = 0;

            for (int i=2; i <= Math.Sqrt(x);  ++i)
            {
                if(x%i == 0)
                {
                    cnt++;
                }
            }

            return cnt == 0 && x != 1;
        }
        
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("Prime.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs);

            string line = sr.ReadLine();
            string[] arr = line.Split(' ');
            int min=0;
            int k=0;

            while (!IsPrime(arr[k]))
            {
                min = int.Parse(arr[k + 1]);
                k++;
            }
            int minimum = min;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (IsPrime(arr[i]) && int.Parse(arr[i])<=minimum)
                {
                    minimum = int.Parse(arr[i]);
                }
            }

            sw.Write(minimum + " is the minimum prime number");

            sw.Close();
            sr.Close();
            fs.Close();
        }
    }
}
