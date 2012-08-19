using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell.ProducerConsumer
{
    class PrettyPrinterConsumer : IConsumer
    {
        public void Consume(Object buffer)
        {
            Console.WriteLine(String.Format("------------" + System.Environment.NewLine + "{0}" + System.Environment.NewLine + "--------------", buffer == null ? "" : buffer));
        }
    }
}
