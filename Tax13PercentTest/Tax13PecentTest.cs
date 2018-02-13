using NUnit.Framework;
using UtilitiesCalculator.Business.TaxModel;

namespace Tax13PercentTest
{
    [TestFixture]
    public class Tax13PecentTest
    {
        Tax13Percent tax13 = new Tax13Percent();

        [Test,
         TestCase(0, 0),
         TestCase(100, 13),
         TestCase(1000, 130)]

        public void ShouldCalculateTaxCorrectly(decimal a, decimal b)
        {
            Assert.AreEqual(b, tax13.ICalculateTax(a));
        }
    }
}
