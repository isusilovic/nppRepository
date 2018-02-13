using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using System;
using UtilitiesCalculator.Business;
using UtilitiesCalculator.Business.AccountingModels;

namespace UtilitiesCalculator.NUnit.Tests
{
   [TestClass]
    public class WaterAccountingPersonsSharesModelNUnitTests
    {
        private WaterAccountingPersonsSharesModel GetWaterAccountingPersonsSharesModel()
        {
            var wapsm = new WaterAccountingPersonsSharesModel();
            return wapsm;
        }
        [TestMethod]
        public void DoAccountingConsumptionZeroReturnsFixedExpenses()
        {
            WaterAccountingPersonsSharesModel wapsm = GetWaterAccountingPersonsSharesModel();
            double expected = (double)ConstantsBusiness.WaterBillFixedAmount;
            double result = (double)wapsm.DoAccounting(0);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result, 0.001);
        }


        [TestMethod]
        public void DoAccountingNegativeConsumptionThrowsException()
        {
           
            WaterAccountingPersonsSharesModel wapsm = GetWaterAccountingPersonsSharesModel();
            var input = -100;
            try
            {
                wapsm.DoAccounting(input);
                Assert.Fail();
            }
            catch(ArgumentException expected)
            {
                Assert.AreEqual("Consumption can not be negative", expected.Message);
            }
            
            
        }
    }
}
