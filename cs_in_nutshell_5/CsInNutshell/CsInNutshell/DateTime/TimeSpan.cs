using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Nutshell.DateTimet
{
    [TestFixture]
    class TimeSpanTeste
    {
        [Test]
        [TestCase(2.5, 30, Result = 3)]
        public double SumHourMinutesTest(Double a, Double b)
        {
            TimeSpan t = TimeSpan.FromHours(a) + TimeSpan.FromMinutes(b);
            return t.Hours;
        }

        [Test]
        public void DiaTem24HorasTest()
        {
            Assert.AreEqual(TimeSpan.FromDays(1.0), TimeSpan.FromHours(24));
        }

        [Test]
        public void DiferençaDeTotalTest()
        {
            Assert.AreNotEqual(TimeSpan.FromHours(2.5).Hours, TimeSpan.FromHours(2.5).TotalHours);
        }
    }
}
