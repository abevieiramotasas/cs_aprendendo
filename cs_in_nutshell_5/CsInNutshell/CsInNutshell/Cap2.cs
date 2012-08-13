using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell
{
    class Cap2
    {
        // hexadecimal
        public int valor = 0x12AF;
        public double million = 1E06;

        public void UsingChecked()
        {
            // sem checked
            int a = int.MaxValue;
            a++;
            if (a == int.MinValue)
            {
                Console.WriteLine("Operacao de incremento foi silenciada");
            }
            // com checked
            try
            {
                checked
                {
                    a = int.MaxValue;
                    a++;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Operacao de incremento com overflow lançou exceção");
            }

        }
    }
}
