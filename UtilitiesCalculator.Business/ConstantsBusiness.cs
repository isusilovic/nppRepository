using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesCalculator.Business
{
    public class ConstantsBusiness
    {
        #region Shares
        public static decimal numberOfWaterUsersInBuilding = 19;
        public static decimal numberOfWaterUsersInAppartment = 2;
        #endregion

        #region fixed costs
        public static decimal WaterBillFixedAmount = 18.92m;
        #endregion

        #region taxable prices

        public static decimal taxableSupplySevice = 4.21m;
        public static decimal taxableServiceWasteWaterDrainage = 1;
        public static decimal taxableServicePurification = 1.28m;

        #endregion
        #region untaxable prices
        public static decimal WaterUsageCharge = 2.85m;
        public static decimal WaterProtectionCharge = 0.405m;
        public static decimal DevelopmentChargeWater = 0.30m;
        public static decimal DevelopmentChargeDrainage = 0.70m;
        public static decimal DevelopmentChargePurification = 3.70m;
        #endregion

    }
}
