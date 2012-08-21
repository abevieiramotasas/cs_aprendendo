using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsInNutshell.ProducerConsumer;
using CsInNutshell.Threading;
using System.Threading;

namespace CsInNutshell
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer("1 - Abelardo Vieira Mota");
            Printer p2 = new Printer("2 - Juliana Vieira Mota");
            Thread t1 = new Thread(p.Print);
            Thread t2 = new Thread(p2.Print);
            t1.Start();
            t2.Start();
        }

        class Logger
        {
            public void Log(Cap4 c)
            {
                Console.WriteLine(String.Format("O valor é {0}", c.Valor));
            }
            public void LogFeio(Cap4 c)
            {
                Console.WriteLine("Logando");
            }

            public void Log(object sender, ArgumentosDoEvento e)
            {
                Console.WriteLine(String.Format("Msg chegou {0}", e.msg));
            }
        }

        static void Main2()
        {
            // cap2
            /*
            Console.WriteLine(String.Format("Argumentos : {0}", args == null || args.Length == 0? "Vazio": String.Join(" ", args)));
            Cap2 c = new Cap2();
            Console.WriteLine(c.valor);
            Console.WriteLine(c.million);
            c.UsingChecked();
             */
            /*
            Logger l = new Logger();
            Cap4.PosExecute p = l.Log;
            p += l.Log;
            p += l.LogFeio;
            p -= l.Log;
            Cap4.PreExecute pe = l.LogFeio;
            pe += l.Log;
            Cap4 c = new Cap4(pe, p);
            c.Execute();
             */
            // event
            /*
            TriggerEvent t = new TriggerEvent();
            TestaEvento t_e = new TestaEvento("Testa 1");
            TestaEvento t_e_2 = new TestaEvento("Testa 2");
            t.MsgEnviada += t_e.Printa;
            t.MsgEnviada += t_e_2.Printa;
            t.Trigger("Trigger");
            // testando unsubscribe
            Console.WriteLine("Testando unsubscribe em ordem diferente do subscribe");
            t.MsgEnviada -= t_e_2.Printa;
            t.Trigger("Trigger pos subscribe");
             */
            // event framework
            /*
            EventTeste t = new EventTeste();
            Logger l1 = new Logger();
             */
            //t.ChegouMsg += l1.Log;
            // lambda, closure
            /*
            Lambda.PrintCapitalized("Testando lambda");
            Lambda.TestaClosure();
            Func<String, String> c_1 = Lambda.Concatenador("Base 1 ");
            Func<String, String> c_2 = Lambda.Concatenador("Base 2 ");
            Console.WriteLine(c_1("Resto 1"));
            Console.WriteLine(c_2("Resto 2"));
             */
            // try catch throw
            /*
            try
            {
                TryCatch.Throw2();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("-----------------------");
            try
            {
                TryCatch.Throw3();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("-----------------------");
            try
            {
                TryCatch.Throw4();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
             */
            // Enumeration
            /*
            foreach (int i in MeuEnumerator.Fibonacci(10))
            {
                Console.WriteLine(i);
            }
             */
            // Testando Nullable
            /*
            int? i = 5;
            // mesma coisa
            int j = i.Value;
            j = (int) i;
            i = null;
            int k = i ?? 10;
            Console.WriteLine(k);
             */
            // Operador - overload, implicit e explicit conversions
            /*
            Operador o = new Operador(10);
            Console.WriteLine(o + 10);
            int valor = o;
            Operador o_i = (Operador) valor;
             */
            // extension
            /*
            Console.WriteLine("testando extension method".GetPalavrao());
            Console.WriteLine("testando extension method".GetPalavrao().Beaultify());
             */
            // Observer
            // dois consumers
            IConsumer c_1 = new PrinterConsumer();
            IConsumer c_2 = new PrettyPrinterConsumer();
            CsInNutshell.ProducerConsumer.Buffer buffer = new CsInNutshell.ProducerConsumer.Buffer();
            buffer.OnAddItem += c_1.Consume;
            buffer.OnAddItem += c_2.Consume;
            buffer.OnAddItem += c_1.Consume;
            Producer p = new Producer();
            p.OnAddItem += buffer.AddItem;
            p.Produce("Testando");
        }
    }
}
