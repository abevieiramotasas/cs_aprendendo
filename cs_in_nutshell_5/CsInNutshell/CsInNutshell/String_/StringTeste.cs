using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

// Stringt por ficar ambiguo com o System.String e eu não estar com paciencia pra arrumar a referencia nas outras classes que usam String hehe
namespace Nutshell.Stringt
{
 
    [TestFixture]
    class StringTeste
    {
        [Test]
        public void EmptyStringTest()
        {
            string s = string.Empty;
            Assert.AreEqual("", s);
            Assert.AreEqual(0, s.Length);
            Assert.AreEqual("", s + s);
        }

        [Test]
        public void StringIndexTest(
            [Values("aaaa", "bbbb", "cccc")] string a)
        {
            char a_ = a[0];
            foreach (char c in a)
            {
                Assert.AreEqual(a_, c);
            }
        }

        [Test]
        public void ContainsTest(
            [Values("abelardo vieira mota")] string a)
        {
            Assert.IsTrue(a.Contains("abelardo"));
            Assert.IsTrue(a.Contains("mota"));
        }

        [Test]
        public void IndexOfIgnoreCaseTest(
            [Values("Abelardo Vieira Mota")] string a)
        {
            Assert.AreNotEqual(-1, a.IndexOf("abelardo", StringComparison.InvariantCultureIgnoreCase));
            Assert.AreNotEqual(-1, a.IndexOf("mota", StringComparison.InvariantCultureIgnoreCase));
        }

        [Test]
        public void IndexOfAnyTest(
            [Values("Abelardo 1 Vieira")] string a)
        {
            Assert.AreEqual(9, a.IndexOfAny("0123456789".ToCharArray()));
        }

        [Test]
        public void SubstringTest(
            [Values("Abelardo Vieira Mota")] string a)
        {
            Assert.AreEqual("Abelardo", a.Substring(0, 8));
            Assert.AreEqual("Vieira", a.Substring(9, 6));
            Assert.AreEqual("Mota", a.Substring(a.IndexOf('M'), 4));
            Assert.AreEqual("Vieira Mota", a.Substring(9));
        }

        [Test]
        public void InsertTest(
            [Values("abelardo", "joão")] string a,
            [Values("vieira")] string b)
        {
            string r = a + b;
            Assert.AreEqual(r, a.Insert(a.Length, b));
        }

        [Test]
        public void RemoveTest(
            [Values("abelardo vieira mota")] string a)
        {
            Assert.AreEqual("abelardo mota", a.Remove(9, 7));
            Assert.AreEqual("abelardo mota", a.Remove(a.IndexOf('v'), 7));
        }

        [Test]
        [TestCase("a", Result="*********a")]
        [TestCase("abe", Result="*******abe")]
        public string PadTest(
            string a)
        {
            return a.PadLeft(10, '*');
        }

        [Test]
        public void TrimTest()
        {
            Assert.AreEqual("abe", "                       abe".TrimStart());
            Assert.AreEqual("abe", "abe                                    ".TrimEnd());
            Assert.AreEqual("abe".PadLeft(100, '*').TrimStart('*'), "abe");
        }

        [Test]
        [TestCase("abelardo", "abe", "bo", Result = "bolardo")]
        [TestCase("juliana", "ju", "bo", Result = "boliana")]
        public string ReplaceTest(string a, string f, string t)
        {
            return a.Replace(f, t);
        }

        [Test]
        public void SplitJoinTest(
            [Values("abelardo vieira mota", "juliana silva sauro", "bilolo caseiro")] string nome)
        {
            Assert.AreEqual(nome, String.Join(" ", nome.Split()));
        }

        [Test]
        public void FormatTest(
            [Values("O Abelardo é {0} e {1}")] string composite, 
            [Values("Feio", "Engraçado", "Careca")] string v_1,
            [Values("Feio", "Engraçado", "Careca")] string v_2)
        {
            string resultado_format = String.Format(composite, v_1, v_2);
            string resultado_replace = composite.Replace("{0}", v_1);
            resultado_replace = resultado_replace.Replace("{1}", v_2);
            Assert.AreEqual(resultado_replace, resultado_format);
        }

        [Test]
        public void FormatMinimunWidthTest(
            [Values("abelardo", "juliana", "saulo")] string name)
        {
            // right align
            string resultado = String.Format("{0, 20}", name);
            Assert.AreEqual(20, resultado.Length);
            // left align
            resultado = String.Format("{0, -20}", name);
            Assert.AreEqual(20, resultado.Length);
        }

        [Test]
        public void EqualsCaseInvariantTest(
            [Values("Abelardo", "Juliana")] string name)
        {
            Assert.IsTrue(name.ToLower().Equals(name, StringComparison.InvariantCultureIgnoreCase));
            // compare case insensitive
            Assert.AreEqual(0, String.Compare(name, name.ToUpper(), true));
        }

        // sabe que nem sei ao certo que diabos isso testa hehe
        [Test]
        public void CultureInfoCompareTest(
            [Values("Muller")] string name,
            [Values("Müller")] string name_)
        {
            System.Globalization.CultureInfo c = System.Globalization.CultureInfo.GetCultureInfo("de-DE");
            Assert.AreNotEqual(0, String.Compare(name, name_, false, c));
        }
    }
}
