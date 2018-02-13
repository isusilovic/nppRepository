using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesCalculator.Dao.Implementations;
using UtilitiesCalculator.Dao.Repository;
using UtilitiesCalculator.Dao.Db;
using UtilitiesCalculator.Dao.Model;

namespace UtilitiesCalculator.MoqTest
{
    public class CalculateBillTest
    {
        private static UtilitiesCalculatorContext db;
        private static IRepository repo = new EfRepository(db);

        Mock<IBillCalculator> mockCalculator = new Mock<IBillCalculator>();
        WaterBillCalculator calc = new WaterBillCalculator(mockCalculator.Object);
        //var result = calc.CalculateBill(new Bill());
      
    }
}
