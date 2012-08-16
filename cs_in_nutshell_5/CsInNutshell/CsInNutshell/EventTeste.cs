using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell
{
    class EventTeste
    {
        // definição do delegate
        public delegate void EventHandler<ArgumentosDoEvento>(object source, ArgumentosDoEvento args);

        public event EventHandler ChegouMsg;

        protected virtual void OnChegouMsg(ArgumentosDoEvento e)
        {
            if (ChegouMsg != null) ChegouMsg(this, e);
        }

        public void ReceberMsg(string msg)
        {
            OnChegouMsg(new ArgumentosDoEvento(msg));
        }
    }

    class ArgumentosDoEvento : System.EventArgs
    {
        public readonly string msg;

        public ArgumentosDoEvento(string msg)
        {
            this.msg = msg;
        }
    }


}
