using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell.ProducerConsumer
{
    class Buffer : IBuffer
    {
        public delegate void AddedItem(Object buffer);
        public event AddedItem OnAddItem;

        public void AddItem(Object item)
        {
            if (OnAddItem != null)
            {
                OnAddItem(item);
            }
        }
    }
}
