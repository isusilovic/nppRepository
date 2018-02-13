using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesCalculator.Business.TaxModel
{
    public class Tax25Percent : ICalculateTax
    {
        private const decimal tax = 0.25m;
        public decimal ICalculateTax(decimal amount)
        {
            return amount * tax;
        }
    }
}
