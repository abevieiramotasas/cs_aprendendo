using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell
{
    class Lambda
    {
        static Func<String, String> Capitalize = (String x) => x.ToUpper() + " passou pelo Capitalize";

        static Func<String, String> DoNothing = Capitalize;

        static int value = 2;

        static Func<int, int> SomaComValue = (int x) => x + value;

        static Lambda()
        {
            DoNothing += (x) => x.ToLower() + " passou pelo Loweralize";
        }

        public static void PrintCapitalized(String s)
        {
            Console.WriteLine(Capitalize(s));
            Console.WriteLine(DoNothing(s));

        }

        public static void TestaClosure()
        {
            Console.WriteLine(SomaComValue(10));
            value = 4;
            Console.WriteLine(SomaComValue(10));
        }

        public static Func<String, String> Concatenador(String s)
        {
            return (x) => String.Concat(new String[]{s, x});
        }
    }
}
