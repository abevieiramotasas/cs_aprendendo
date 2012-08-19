using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell.ProducerConsumer
{
    interface IProducer
    {
        void Produce(Object item);
    }
}
