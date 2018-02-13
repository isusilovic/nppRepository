using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesCalculator.Business.TaxModel
{
    public interface ICalculateTax
    {
        decimal ICalculateTax(decimal amount);
    }
}
