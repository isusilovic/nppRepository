using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesCalculator.Dao.Db;

namespace UtilitiesCalculator.Dao.Model
{
    [Table("Bills")]
    public class Bill
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public BillType BillType { get; set; }
        public decimal Amount { get; set; }
        public ICollection<Reading> Readings { get; set; }

    }
}
