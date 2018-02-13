using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesCalculator.Dao.Db;

namespace UtilitiesCalculator.Dao.ViewModel
{
    public class BillVM
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public BillType BillType { get; set; }
        public decimal Amount { get; set; }
    }
}
