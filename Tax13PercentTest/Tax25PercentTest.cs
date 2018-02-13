using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesCalculator.Business.TaxModel;

namespace Tax13PercentTest
{
    [TestFixture]
    public class Tax25PecentTest
    {
        Tax25Percent tax13 = new Tax25Percent();

        [Test,
         TestCase(0, 0),
         TestCase(100, 25),
         TestCase(1000, 250)]

        public void ShouldCalculateTaxCorrectly(decimal a, decimal b)
        {
            Assert.AreEqual(b, tax13.ICalculateTax(a));
        }
    }
}
