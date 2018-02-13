using Microsoft.VisualStudio.TestTools.UnitTesting;

using UtilitiesCalculator.Business.AccountingModels;

namespace UtilitiesCalculator.Tests
{
    [TestClass]
    public class WaterAccountingPersonsSharesModelTest
    {
        [TestMethod]
        public void ShouldDoWaterAccountingPersonsShares()
        {
            WaterAccountingPersonsSharesModel wapsm = new WaterAccountingPersonsSharesModel();
            double result = (double)wapsm.DoAccounting(100);
            Assert.AreEqual(179.8536, result, 0.001);
        }
    }
}
