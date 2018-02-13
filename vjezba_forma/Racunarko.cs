using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitiesCalculator.Dao.Db;
using UtilitiesCalculator.Dao.Repository;

namespace vjezba_forma
{
    public partial class Racunarko : Form
    {
        EfRepository _repo;

        public Racunarko(EfRepository repo)
        {
            InitializeComponent();
            this._repo = repo;
        }

        private void rbType_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnElectricEnergy.Checked)
            {
                //Napuni tablicu s podatcima za struju
                FillBills(BillType.ElectricEnergy);
            }
            else if (rbtnGas.Checked)
            {
                //Napuni tablicu s podatcima za vodu
                FillBills(BillType.Gas);
            }
            else if (rbtnUtilities.Checked)
            {
                //Napuni tablicu s podatcima za vodu
                FillBills(BillType.Utilities);
            }
            else if (rbtnWater.Checked)
            {
                //Napuni tablicu s podatcima za vodu
                FillBills(BillType.Water);
            }
            else if (rbtnTermalEnergy.Checked)
            {
                //Napuni tablicu s podatcima za vodu
                FillBills(BillType.ThermalEnergy);
            }
            else if (rbtnIt.Checked)
            {
                //Napuni tablicu s podatcima za vodu
                FillBills(BillType.ITCosts);
            }
        }

        private void FillBills(BillType billType)
        {
            switch (billType)
            {
                case BillType.ElectricEnergy:
                    dgvListBills.DataSource = _repo.GetDoubleReadingBills(BillType.ElectricEnergy);
                    break;
                case BillType.Water:
                    dgvListBills.DataSource = _repo.GetSingleReadingBills(BillType.Water);
                    break;
                case BillType.Gas:
                    dgvListBills.DataSource = _repo.GetSingleReadingBills(BillType.Gas);
                    break;
                case BillType.ThermalEnergy:
                    dgvListBills.DataSource = _repo.GetSingleReadingBills(BillType.ThermalEnergy);
                    break;
                case BillType.Utilities:
                    dgvListBills.DataSource = _repo.GetSingleReadingBills(BillType.Utilities);
                    break;
                case BillType.ITCosts:
                    dgvListBills.DataSource = _repo.GetSingleReadingBills(BillType.ITCosts);
                    break;
            }
        }

        private void Racunarko_Load(object sender, EventArgs e)
        {

        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            if (rbtnElectricEnergy.Checked)
            {
                AddDoubleReadingBill electricityBillForm = new AddDoubleReadingBill(_repo);
                electricityBillForm.ShowDialog();
                FillBills(BillType.ElectricEnergy);
            }
            else if (rbtnWater.Checked)
            {
                AddSingleReadingBill addWaterBillForm = new AddSingleReadingBill(_repo);
                addWaterBillForm.ShowDialog();
                FillBills(BillType.Water);
            }
        }
    }
}
