using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Nutshell.DateTimet
{
    [TestFixture]
    class DateTimeTeste
    {

        [Test]
        public void DefaultTimeTeste()
        {
            DateTime date = new DateTime(2012, 8, 21);
            Assert.AreEqual(0, date.Hour);
            Assert.AreEqual(0, date.Minute);
            Assert.AreEqual(0, date.Millisecond);
            Assert.AreEqual(DateTimeKind.Unspecified, date.Kind);
        }


        [Test]
        public void EqualsOffsetTeste()
        {
            DateTimeOffset d_f1 = new DateTimeOffset(2012, 8, 21, 10, 0, 0, TimeSpan.FromHours(10));
            DateTimeOffset d_f2 = new DateTimeOffset(2012, 8, 21, 0, 0, 0, TimeSpan.Zero);
            Assert.AreEqual(d_f1, d_f2);
        }

        [Test]
        public void DefaultKindImplicitConversionTeste()
        {
            DateTime d = new DateTime(2012, 8, 21);
            DateTimeOffset d_o = d;
            Assert.AreEqual(System.TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now), d_o.Offset);
            d = new DateTime(2012, 8, 21, 0, 0, 0, DateTimeKind.Utc);
            d_o = d;
            Assert.AreEqual(TimeSpan.Zero, d_o.Offset);
        }

        [Test]
        public void DateTimeFromDateTimeOffsetTest()
        {
            DateTimeOffset d_o1 = new DateTimeOffset(2012, 8, 21, 10, 0, 0, TimeSpan.FromHours(10));
            DateTimeOffset d_o2 = new DateTimeOffset(2012, 8, 21, 0, 0, 0, TimeSpan.Zero);
            Assert.AreEqual(d_o1.UtcDateTime, d_o2.UtcDateTime);
        }

        [Test]
        public void TodayTest([Values(8)] int mes)
        {
            DateTime hoje = DateTime.Today;
            Assert.AreEqual(mes, hoje.Month);
        }

        [Test]
        public void AddDayTest([Range(1, 12)] int mes)
        {
            DateTime d = new DateTime(2012, mes, 1);
            Assert.AreEqual(d.Month % 12 + 1, d.AddMonths(1).Month);
        }
    }
}
