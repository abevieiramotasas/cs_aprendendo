using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Diagnostics;

namespace Nutshell.Stringt
{
    [TestFixture]
    class StringBuilderTeste
    {
        [Test, Ignore("Não deterministico, mas mostra que na maior parte dos casos, o tempo gasto no resize pra aumentar o size do buffer é maior que o tempo de alocar, inicialmente, um buffer de tamanho suficiente")]
        public void ResizeTest(
            [Range(200, 300, 50)] int size)
        {
            Stopwatch sw = null;
            const string STRING_GRANDE = "Abelardo Vieira Mota esta string tem mais de 16 caracteres que é o limite default do StringBuilder, logo ele irá resizear";
            TimeSpan? usingDefaultSize = null;
            TimeSpan? nUsingDefaultSize = null;
            // resize
            sw = new Stopwatch();
            sw.Start();
            StringBuilder sb = new StringBuilder("Base");
            sb.Append(STRING_GRANDE);
            sw.Stop();
            usingDefaultSize = sw.Elapsed;
            // n resize
            sw = new Stopwatch();
            sw.Start();
            StringBuilder sb_ = new StringBuilder("Base", size);
            sb_.Append(STRING_GRANDE);
            sw.Stop();
            nUsingDefaultSize = sw.Elapsed;
            // verificando que tempo de resize é altinho
            Assert.Greater(usingDefaultSize, nUsingDefaultSize);
        }

        [Test]
        [TestCase("Abelardo {0}", "Vieira")]
        public void AppendFormatTest(
             string inicial,
             string final)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(inicial, final);
            Assert.AreEqual("Abelardo Vieira", sb.ToString());
        }

        [Test]
        [TestCase("Abelardo", "Vieira")]
        public void NewLineAppendTest(string inicial, string final)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(inicial);
            sb.AppendLine();
            sb.Append(final);
            Assert.AreEqual(inicial + System.Environment.NewLine + final, sb.ToString());
        }

    }
}
