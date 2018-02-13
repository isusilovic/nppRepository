using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesCalculator.Business.TaxModel
{
    public class Tax13Percent : ICalculateTax
    {
        private const decimal tax = 0.13m;
        public decimal ICalculateTax(decimal amount)
        {            
            return amount*tax;
        }
    }
}
