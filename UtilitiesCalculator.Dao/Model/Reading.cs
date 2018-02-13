using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesCalculator.Dao.Model
{
    [Table("Readings")]
    public class Reading
    {
        public int ReadingId { get; set; }
        public string ReadingName { get; set; }
        //public DateTime ReadingDate { get; set; }
        public string ReadingValue { get; set; }
        public int BillId { get; set; }

        [ForeignKey("BillId")]
        public virtual Bill Bill { get; set; }
    }
}
