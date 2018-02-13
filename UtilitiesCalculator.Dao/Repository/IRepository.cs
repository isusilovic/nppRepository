using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesCalculator.Dao.Db;
using UtilitiesCalculator.Dao.Model;
using UtilitiesCalculator.Dao.ViewModel;

namespace UtilitiesCalculator.Dao.Repository
{
    public interface IRepository
    {
         void AddSingleReadingBill(DateTime date, BillType billType, string readingValue);
         List<SingleReadingBillVM> GetSingleReadingBills(BillType billType);
         void AddDoubleReadingBill(DateTime date, BillType billType, string readingValueFirst, string readingValueSecond);
         List<DoubleReadingBillVM> GetDoubleReadingBills(BillType billType);
         Bill GetBillBeforeDate(BillType billType, DateTime date);
    }
}
