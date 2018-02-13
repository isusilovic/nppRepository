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
    public partial class AddSingleReadingBill : Form
    {
        private IRepository _repo;

        public AddSingleReadingBill(IRepository _repo)
        {
            InitializeComponent();
            this._repo = _repo;
        }

        private void AddSingleReadingBill_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSingleReading_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSingleReading.Text))
            {
                MessageBox.Show("Sva polja su obavezna", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            _repo.AddSingleReadingBill(dtpSingleReading.Value, BillType.Water, tbSingleReading.Text);
            this.Close();
        }
    }
}
