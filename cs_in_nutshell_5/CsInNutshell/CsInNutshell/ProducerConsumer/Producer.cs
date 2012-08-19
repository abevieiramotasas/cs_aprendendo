using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell.ProducerConsumer
{
    class Producer : IProducer
    {
        public delegate void AddItem(Object item);
        public event AddItem OnAddItem;
        public void Produce(Object item)
        {
            if (OnAddItem != null)
            {
                OnAddItem(item);
            }
        }
    }
}
