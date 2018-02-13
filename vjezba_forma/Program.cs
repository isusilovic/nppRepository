using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitiesCalculator.Dao.Db;
using UtilitiesCalculator.Dao.Repository;

namespace vjezba_forma
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using(UtilitiesCalculatorContext db = new UtilitiesCalculatorContext())
            {
                var repository = new EfRepository(db);
                Application.Run(new Racunarko(repository));
            }
        }
    }
}
