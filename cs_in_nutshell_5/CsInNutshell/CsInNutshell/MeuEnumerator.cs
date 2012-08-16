using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsInNutshell
{
    class MeuEnumerator
    {
        public static IEnumerable<int> Fibonacci(int max)
        {
            try
            {
                for (int i = 0, prevFib = 1, curFib = 1; i < max; i++)
                {
                    yield return prevFib;
                    int newFib = prevFib + curFib;
                    prevFib = curFib;
                    curFib = newFib;
                }
            }
            finally
            {
                Console.WriteLine("Terminei de gerar os numeros hehe");
            }
        }
    }
}
