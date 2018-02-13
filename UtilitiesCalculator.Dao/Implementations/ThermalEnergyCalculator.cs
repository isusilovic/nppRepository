using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesCalculator.Dao.Model;
using UtilitiesCalculator.Dao.Repository;

namespace UtilitiesCalculator.Dao.Implementations
{
    public class ThermalEnergyCalculator : IBillCalculator
    {
        private IRepository repository;

        public ThermalEnergyCalculator(IRepository repository)
        {
            this.repository = repository;
        }

        public decimal CalculateBill(Bill bill)
        {
            throw new NotImplementedException();
        }
    }
}
