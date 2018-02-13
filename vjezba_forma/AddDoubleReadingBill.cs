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
    public partial class AddDoubleReadingBill : Form
    {
        private IRepository _repo;

        public AddDoubleReadingBill(IRepository repo)
        {
            InitializeComponent();
            this._repo = repo;

        }

        private void AddMultipleReadingBill_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDoubleReading_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDoubleReadingFirst.Text) || string.IsNullOrEmpty(tbDoubleReadingSecond.Text))
            {
                MessageBox.Show("Sva polja su obavezna", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _repo.AddDoubleReadingBill(dtpDoubleReadingDate.Value, BillType.ElectricEnergy, tbDoubleReadingFirst.Text, tbDoubleReadingSecond.Text);
            this.Close();
        }
    }
}
