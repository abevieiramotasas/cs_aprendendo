using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string filepath = @"C:\Users\Sevana\Desktop\DiarioFacil\python\889.txt";
            string pattern = @"(?<padrao>^[ ]*Nº \d{7}-\d{2}\.\d{4}\.\d\.\d{2}\.\d{4} - Apelação (?:\s|.)*?)\r\r\n\r\r\n";
            string filepath_write = @"C:\Users\Sevana\Desktop\DiarioFacil\python\889_m.txt";

            //MatchCollection m = Crawler.Execute(filepath, pattern);
            Crawler.MatchAndSave(filepath, filepath_write, pattern);
             * */

            // testando gera xml
            string pathDosXML_lucio = @"D:\workspace\workspace-sevana\DiarioFacil\DiarioFacil.Comum\XML";
            //string pathDosXML = @"C:\Users\Sevana\DiarioFacil\DiarioFacil.Comum\XML";
            Util.ExtractFullRegex(pathDosXML_lucio);
        }
    }
}
