using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesCalculator.Dao.Model;
using UtilitiesCalculator.Dao.Repository;

namespace UtilitiesCalculator.Dao.Implementations
{
    public class ElectricEnergyBillCalculator : IBillCalculator
    {
        private IRepository billCalculator;

        public ElectricEnergyBillCalculator(IRepository billCalculator)
        {
            this.billCalculator = billCalculator;
        }

        public decimal CalculateBill(Bill bill)
        {
            throw new NotImplementedException();
        }

       
    }
}
