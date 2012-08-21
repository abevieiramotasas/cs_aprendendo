using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Nutshell.Parsingt
{
    [TestFixture]
    class ParsingTeste
    {
        [Test]
        public void TestaParseDeNumeroLegalPraCarambaPegueiArComOCleanCode()
        {
            int i;
            Boolean sucess = int.TryParse("(1)", System.Globalization.NumberStyles.AllowParentheses | System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out i);
            Assert.IsTrue(sucess);
            // engraçado, mas parenteses indicam que o numer é negativo...
            Assert.AreEqual(-1, i);
        }

    }
}
