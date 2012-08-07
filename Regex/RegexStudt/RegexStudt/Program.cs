using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegexStudt
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = @"\d{5}";
            string[] ss = { "12345", "123ab", "123", "09876" };
            RegexStudy.MatchAgainstArray(ss, c);
        }
    }
}
