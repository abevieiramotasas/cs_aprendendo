using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleIO.ExecuteSamples();
            string[] content = File.ReadAllLines(@"C:\Users\Sevana\Desktop\DiarioFacil\python\889.txt");
            Console.WriteLine("O arquivo possui "+content.Length.ToString()+" linhas");
        }
    }
}
