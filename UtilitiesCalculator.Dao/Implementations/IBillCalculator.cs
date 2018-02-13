using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesCalculator.Dao.Model;

namespace UtilitiesCalculator.Dao.Implementations
{
    public interface IBillCalculator
    {
        decimal CalculateBill(Bill bill);
    }
}
