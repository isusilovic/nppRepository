using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesCalculator.Business;
using UtilitiesCalculator.Business.AccountingModel;
using UtilitiesCalculator.Business.AccountingModels;
using UtilitiesCalculator.Business.TaxModel;
using UtilitiesCalculator.Dao.Db;
using UtilitiesCalculator.Dao.Model;
using UtilitiesCalculator.Dao.Repository;

namespace UtilitiesCalculator.Dao.Implementations
{
    public class WaterBillCalculator : IBillCalculator
    {
        private IRepository repository;
        private IAccountingModel accountingModel;
        public WaterBillCalculator(IRepository repo)
        {
            this.repository = repo;
            this.accountingModel = new WaterAccountingPersonsSharesModel();
        }
        public decimal CalculateBill(Bill bill)
        {
            decimal previousReading = 0m;
            decimal currentReading = 0m;

            currentReading = ExtractReading(bill);

            var lastBill = repository.GetBillBeforeDate(BillType.Water, bill.Date);
            if(lastBill == null)
            {
                Logger.Log.Instance.LogWarning("Can't find last water bill");
                return accountingModel.DoAccounting(previousReading);
            }

            previousReading = ExtractReading(lastBill);

            var result = accountingModel.DoAccounting(currentReading - previousReading);
            return result;
        }

        public decimal ExtractReading(Bill bill)
        {

            decimal currentReading = 0m;

            string currentLowReadingStr = bill.Readings.FirstOrDefault(x => x.ReadingName == Constants.SingleReading)?.ReadingValue;

            if (!string.IsNullOrEmpty(currentLowReadingStr))
            {
                currentReading = decimal.Parse(currentLowReadingStr);
            }


            return currentReading;
        }
       
    }
}
