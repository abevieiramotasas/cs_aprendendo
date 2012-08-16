using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell
{
    class Cap4
    {
        #region delegates
        public delegate void PreExecute(Cap4 c);
        public delegate void PosExecute(Cap4 c);
        #endregion

        private PreExecute pres;
        private PosExecute poss;

        public int Valor { get; set; }

        public Cap4(PreExecute pre, PosExecute pos)
        {
            this.pres = pre;
            this.poss = pos;
        }

        public void Execute()
        {
            pres(this);
            this.Valor += 10;
            poss(this);
        }

    }

    public delegate void Evento(string msg);
    class TriggerEvent
    {
        public event Evento MsgEnviada;
        public void Trigger(string msg)
        {

            MsgEnviada(msg);
        }
    }

    class TestaEvento
    {
        public TestaEvento(string msg)
        {
            this.msg = msg;
        }
        private string msg;
        public void Printa(string msg)
        {
            Console.WriteLine(this.msg + msg);
        }
    }
}
