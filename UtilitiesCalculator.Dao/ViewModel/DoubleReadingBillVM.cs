using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesCalculator.Dao.ViewModel
{
    public class DoubleReadingBillVM:BillVM
    {
        public string FirstReading { get; set; }
        public string SecondReading { get; set; }
    }
}
