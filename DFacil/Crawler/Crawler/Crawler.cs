using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Crawler
{
    class Crawler
    {

        public static MatchCollection Execute(string filepath, string pattern)
        {
            string content = File.ReadAllText(filepath);
            Regex c = new Regex(pattern, RegexOptions.Compiled | RegexOptions.Multiline);
            MatchCollection f_result_collection = c.Matches(content);
            var len = f_result_collection.Count;
            Console.WriteLine(String.Format("Total encontrado {0}", len.ToString()));
            if (len > 0)
            {
                Console.WriteLine(String.Format("Primeiro match encontrado \n\n{0}\n", f_result_collection[0].Groups["padrao"]));
                Console.WriteLine(String.Format("Segundo match encontrado \n\n{0}\n", f_result_collection[1].Groups["padrao"]));
            }
            return f_result_collection;
        }

        public static void MatchAndSave(string file_to_read, string file_to_write, string pattern)
        {
            string content = File.ReadAllText(file_to_read);
            Regex c = new Regex(pattern, RegexOptions.Compiled | RegexOptions.Multiline);
            MatchCollection match_collection = c.Matches(content);
            List<String> matches = new List<String>();
            foreach (Match m in match_collection)
            {
                matches.Add(m.Groups["padrao"].ToString());
            }
            File.WriteAllLines(file_to_write, matches.ToArray());
        }
    }
}
