using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexStudy
{
    class RegexStudy
    {
        public static void ExecuteTeste()
        {
            var c = new Regex(@"\d{5}", RegexOptions.Compiled);
            var s = "01234";
            if (c.IsMatch(s))
            {
                Console.WriteLine("Num é que funciona");
            }
            else
            {
                Console.WriteLine("Algo de errado");
            }
        }

        public static void MatchAgainstArray(string[] array, string regex)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Nenhuma string passada");
            }
            var c = new Regex(regex, RegexOptions.Compiled);
            foreach (string s in array)
            {
                if (c.IsMatch(s))
                {
                    Console.WriteLine(String.Format("A string {0} casou com o padrao {1}", s, c));
                }
                else
                {
                    Console.WriteLine(String.Format("A string {0} não casou com o padrão {1}", s, c));
                }
            }
        }

    }
}
