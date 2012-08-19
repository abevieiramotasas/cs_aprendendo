using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Nutshell.Char
{
    [TestFixture]
    class CharTeste
    {
        // Utilizo Sequential para informar ao NUnit para usar os valores em Values de forma 'pareada'
        // e não utilizar todas as combinações possíveis
        // de forma que os valores que são atribuídos são (a, A), (b, B) e (c, C)
        // Poderia utilizar também o atributo TestCase(params...)
        // [TestCase('a', 'A')]
        [Test, Sequential]
        public void ToUpperInvariantTest(
            [Values('a', 'b', 'c', 'ç')] char a,
            [Values('A', 'B', 'C', 'Ç')] char b)
        {
            // Invariant é utilizado para informar ao método que a versão Upper do caractere
            // deve ser a da língua inglesa.
            // Mesmo que 
            // System.Char.ToUpper(a, System.Globalization.CultureInfo.InvariantCulture);
            Assert.AreEqual(b, System.Char.ToUpperInvariant(a));
        }

        [Test, Sequential]
        public void ToLowerInvariantTest(
            [Values('A', 'B', 'C', 'Ç')] char a,
            [Values('a', 'b', 'c', 'ç')] char b)
        {
            Assert.AreEqual(b, System.Char.ToLower(a));
        }

        [Test]
        public void IsLetterTest(
            [Values('a', 'b', 'ç', 'ã')] char a)
        {
            Assert.IsTrue(System.Char.IsLetter(a));
        }

        [Test]
        public void NIsLetterTest(
            [Values('1', '~', '$', ')')] char a)
        {
            Assert.IsFalse(System.Char.IsLetter(a));
        }
        [Test]
        public void IsUpperTest(
            [Range(65, 90, 1)] int c)
        {
            char c_ = (char)c;
            Assert.IsTrue(System.Char.IsUpper(System.Char.ToUpperInvariant(c_)));
        }

        [Test]
        public void IsDigitTest(
            [Values('1', '5', '9')] char a)
        {
            Assert.IsTrue(System.Char.IsDigit(a));
        }

        [Test]
        public void IsWhitespaceTest(
            [Values('\n', '\t', '\f', '\v', '\r')] char a)
        {
            Assert.IsTrue(System.Char.IsWhiteSpace(a));
        }

        [Test]
        public void IsSymbol(
            [Values('\a')] char a)
        {
            Assert.IsFalse(System.Char.IsSymbol(a));
        }



    }
}
