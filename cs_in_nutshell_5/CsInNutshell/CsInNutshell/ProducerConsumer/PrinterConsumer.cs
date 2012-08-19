using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell.ProducerConsumer
{
    class PrinterConsumer : IConsumer
    {
        public void Consume(Object item)
        {
            String item_m = item as String;
            Console.WriteLine(item_m);
        }
    }
}
