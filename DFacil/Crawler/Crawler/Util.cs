using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Crawler
{
    class Util
    {
        private static Regex fullRegexCrawler = new Regex(@"<inicio><!\[CDATA\[(?<fullregex>.*?)\]\]></inicio>");
        public static void ExtractFullRegex(string dirPath)
        {
            // diretório
            DirectoryInfo di = new DirectoryInfo(dirPath);

            // arquivos filhos do diretorio .xml
            FileInfo[] fis = di.GetFiles("*.xml", SearchOption.AllDirectories);

            foreach (FileInfo fi in fis)
            {
                string fileContent = File.ReadAllText(fi.FullName);
                string[] fullRegex = GenerateFullRegex(fileContent);
                File.WriteAllText(String.Format("{0}.txt", fi.Name), String.Join("|\r\n", fullRegex));
            }
        }

        private static string[] GenerateFullRegex(string fileContent)
        {
            MatchCollection mc = fullRegexCrawler.Matches(fileContent);
            List<String> patterns = new List<String>();
            foreach (Match m in mc)
            {
                patterns.Add(m.Groups["fullregex"].ToString());
            }
            return patterns.ToArray();
        }
    }
}
