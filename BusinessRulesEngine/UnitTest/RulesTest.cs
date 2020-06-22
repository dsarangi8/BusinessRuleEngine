using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using common;
namespace UnitTest
{
    [TestFixture]
    public class RulesTest
    {
        [Test]
        public void TestMethod()
        {
            Payments pment = new Payments();
            pment.setRules(paymentType.book);
        }
    }
}
