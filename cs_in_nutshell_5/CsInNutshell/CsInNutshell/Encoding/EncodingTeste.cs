using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Nutshell.Encoding
{
    [TestFixture]
    class EncodingTeste
    {
        [Test]
        public void IANAEncodingNamesTest()
        {
            foreach (EncodingInfo ef in System.Text.Encoding.GetEncodings())
            {
                Console.WriteLine(ef.Name);
            }
        }
        
        [Test]
        public void ConvertBytesTest(
            [Values("Abelardo", "Bilila heh")] string name,
            [Values("GB18030", "utf-8")] string encoding_name)
        {
            System.Text.Encoding e = System.Text.Encoding.GetEncoding(encoding_name);
            byte[] byte_name = e.GetBytes(name);
            Assert.AreEqual(name, e.GetString(byte_name));
        }

        // to vendo que entendo pn de encoding
        [Test]
        public void Convert2EncodingTypeTest(
            [Values("Hehe", "Oi tudo bem", "Abelardo Vieira Mota")] string msg)
        {
            System.Text.Encoding[] es = new System.Text.Encoding[2];
            es[0] = System.Text.Encoding.GetEncoding("GB18030");
            es[1] = System.Text.Encoding.GetEncoding("utf-8");
            Assert.AreEqual(es[0].GetBytes(msg), es[1].GetBytes(msg));
        }

    }
}
