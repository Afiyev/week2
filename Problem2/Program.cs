using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим файл и читаем то что там написано
            FileStream fs = new FileStream("MaxMin.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            // Строку изменяем на массив которое состоит из чисел 
            string[] number = line.Split(' ');
            int min = int.Parse(number[0]);
            int max = int.Parse(number[0]);

            // Найдем макс и мин
            for (int i = 1; i < number.Length; ++i)
            {
                if (int.Parse(number[i]) <= min)
                {
                    min = int.Parse(number[i]);
                }
                if (int.Parse(number[i]) >= max)
                {
                    max = int.Parse(number[i]);
                }
            }

            Console.WriteLine(max + " is maximum number");
            Console.WriteLine(min + " is minimum number");

            sr.Close();
            fs.Close();


        }
    }
}
        
    

