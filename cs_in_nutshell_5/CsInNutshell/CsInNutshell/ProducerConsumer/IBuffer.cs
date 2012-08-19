using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell.ProducerConsumer
{
    interface IBuffer
    {
        void AddItem(Object item);
    }
}
