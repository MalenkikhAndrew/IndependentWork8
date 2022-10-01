using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Андрей\Desktop\Модуль 2\IndependentWork7\Numbers.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-10,10));
                }
            }
            int k = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    int x = Convert.ToInt32(sr.ReadLine());

                    k += x;
                }
            }
            Console.WriteLine("Сумма всех чисел = {0}",k);
            Console.ReadKey();
        }
    }
}
