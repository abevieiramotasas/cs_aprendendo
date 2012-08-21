using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell.Threading
{
    class Printer
    {
        private string name;
        public Printer(string name)
        {
            this.name = name;
        }
        public void Print()
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine(name);            
        }
    }
}
