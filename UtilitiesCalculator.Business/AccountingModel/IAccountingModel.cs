using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesCalculator.Business.AccountingModel
{
    public interface IAccountingModel
    {
        decimal DoAccounting(decimal meterConsumption);
    }
}
