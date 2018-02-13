using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesCalculator.Dao.Db;
using UtilitiesCalculator.Dao.Model;
using System.Data.Entity;
using UtilitiesCalculator.Dao.ViewModel;
using UtilitiesCalculator.Dao.Implementations;

namespace UtilitiesCalculator.Dao.Repository
{
    public class EfRepository : IRepository
    {
        private UtilitiesCalculatorContext _db;

        public EfRepository(UtilitiesCalculatorContext db)
        {
            this._db = db;
        }

        #region SingleReadingBill

        public void AddSingleReadingBill(DateTime date, BillType billType, string readingValue)
        {
            Reading r = new Reading
            {
                ReadingName = Constants.SingleReading,
                ReadingValue = readingValue,

            };

            AddBill(date, billType, r);
        }

        public List<SingleReadingBillVM> GetSingleReadingBills(BillType billType)
        {
            var billsFromDatabase = _db.Bills.Include(x => x.Readings).
                Where(x => x.BillType == billType).ToList();

            List<SingleReadingBillVM> resultList = new List<SingleReadingBillVM>();

            foreach(var bill in billsFromDatabase)
            {
                var vm = new SingleReadingBillVM()
                {
                    BillType = billType,
                    Id = bill.Id,
                    Date = bill.Date,
                    Amount = bill.Amount
                };

                if(bill.Readings != null && bill.Readings.Count == 1)
                {
                    vm.SingleReading = bill.Readings.ToList()[0].ReadingValue;

                }
                resultList.Add(vm);
            }
            return resultList;
        }
        #endregion

        #region DoubleReadingBill

        public void AddDoubleReadingBill(DateTime date, BillType billType, string readingValueFirst, string readingValueSecond)
        {
            Reading rFirst = new Reading
            {
                ReadingName = Constants.MultipleReadingFirst,
                ReadingValue = readingValueFirst
            };
            Reading rSecond = new Reading
            {
                ReadingName = Constants.MultipleReadingSecond,
                ReadingValue = readingValueSecond
            };

            AddBill(date, billType, rFirst, rSecond);
        }


        public List<DoubleReadingBillVM> GetDoubleReadingBills(BillType billType)
        {
            var billsFromDatabase = _db.Bills.Include(x => x.Readings).
                Where(x => x.BillType == billType).ToList();

            List<DoubleReadingBillVM> resultList = new List<DoubleReadingBillVM>();

            foreach (var bill in billsFromDatabase)
            {
                var vm = new DoubleReadingBillVM()
                {
                    BillType = billType,
                    Id = bill.Id,
                    Date = bill.Date,
                    Amount = bill.Amount
                };

                if (bill.Readings != null && bill.Readings.Count == 2)
                {
                    foreach(var reading in bill.Readings)
                    {
                        if( reading.ReadingName == Constants.MultipleReadingFirst)
                        {
                            vm.FirstReading = reading.ReadingValue;
                        }
                        if( reading.ReadingName == Constants.MultipleReadingSecond)
                        {
                            vm.SecondReading = reading.ReadingValue;
                        }
                    }

                }
                resultList.Add(vm);
            }
            return resultList;
        }

        #endregion


        public Bill GetBillBeforeDate(BillType billType, DateTime date)
        {
            var billsFromDatabase = _db.Bills.Include(x => x.Readings).
                Where(x => x.BillType == billType).ToList();

            return billsFromDatabase.Where(x => x.Date < date).OrderBy(x => x.Date).LastOrDefault();
        }
        private void AddBill(DateTime date, BillType billType,params Reading[] readings)
        {
            IBillCalculator calculator = BillCalculatorFactory.GetBillCalculator(billType, this);

            Bill bill = new Bill
            {
                Date = date,
                BillType = billType,
                Readings = readings,
            };
            bill.Amount = calculator.CalculateBill(bill);

            _db.Bills.Add(bill);
            _db.SaveChanges();
        }

    }
}
