using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Андрей\Desktop\Модуль 2\IndependentWork7";
            string[] files=Directory.GetFiles(path,"*",SearchOption.AllDirectories );
            foreach(string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();    
        }
    }
}
