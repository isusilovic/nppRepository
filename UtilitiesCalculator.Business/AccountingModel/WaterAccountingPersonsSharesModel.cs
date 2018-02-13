using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesCalculator.Business.TaxModel;
using UtilitiesCalculator.Business.AccountingModel;

namespace UtilitiesCalculator.Business.AccountingModels
{
    public class WaterAccountingPersonsSharesModel : IAccountingModel
    {
        private static decimal personsInBuilding = ConstantsBusiness.numberOfWaterUsersInBuilding;
        private static decimal personsInApartment = ConstantsBusiness.numberOfWaterUsersInAppartment;

        ICalculateTax waterTax = new Tax13Percent();
        public decimal DoAccounting(decimal meterConsumption)
        {
            if (meterConsumption < 0) throw new ArgumentException("Consumption can not be negative");

            decimal consumption = 0;
            consumption += (decimal)(personsInApartment / personsInBuilding) * meterConsumption;

            decimal taxableCosts = consumption * (ConstantsBusiness.taxableServicePurification
                + ConstantsBusiness.taxableSupplySevice + ConstantsBusiness.taxableServiceWasteWaterDrainage);

            decimal unTaxableCosts = consumption * (ConstantsBusiness.WaterProtectionCharge + ConstantsBusiness.WaterUsageCharge 
                + ConstantsBusiness.DevelopmentChargeDrainage + ConstantsBusiness.DevelopmentChargePurification 
                + ConstantsBusiness.DevelopmentChargeWater);

            return (waterTax.ICalculateTax(taxableCosts) + taxableCosts + unTaxableCosts + ConstantsBusiness.WaterBillFixedAmount);
        }
    }
}
