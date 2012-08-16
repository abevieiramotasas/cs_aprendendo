using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell
{
    class Operador
    {
        private int valor {get;set;}

        public Operador(int valor)
        {
            this.valor = valor;
        }

        public static int operator + (Operador fonte, int valor)
        {
            return fonte.valor + valor;
        }

        public static implicit operator int(Operador o)
        {
            return o.valor * 10;
        }

        public static explicit operator Operador(int valor)
        {
            return new Operador(valor);
        }

    }
}
