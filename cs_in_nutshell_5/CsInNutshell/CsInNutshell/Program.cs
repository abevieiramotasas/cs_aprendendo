using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("Argumentos : {0}", args == null || args.Length == 0? "Vazio": String.Join(" ", args)));
            Cap2 c = new Cap2();
            Console.WriteLine(c.valor);
            Console.WriteLine(c.million);
            c.UsingChecked();
        }
    }
}
