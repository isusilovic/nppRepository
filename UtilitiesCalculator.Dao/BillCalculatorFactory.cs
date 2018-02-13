using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesCalculator.Dao.Db;
using UtilitiesCalculator.Dao.Implementations;
using UtilitiesCalculator.Dao.Repository;
using UtilitiesCalculator.Logger;

namespace UtilitiesCalculator.Dao
{
    public class BillCalculatorFactory
    {
        public static IBillCalculator GetBillCalculator(BillType billType, IRepository repository)
        {
            switch (billType)
            {
                case BillType.ElectricEnergy:
                    return new ElectricEnergyBillCalculator(repository);
                case BillType.Gas:
                    return new GasCalculator(repository);
                case BillType.ITCosts:
                    return new ITCostsCalculator(repository);
                case BillType.ThermalEnergy:
                    return new ThermalEnergyCalculator(repository);
                case BillType.Water:
                    return new WaterBillCalculator(repository);
                default:
                    Logger.Log.Instance.LogError("Can not found Calculator for " + billType.ToString() + " bill type");
                    throw new NotSupportedException();
            }
        }
    }
}
