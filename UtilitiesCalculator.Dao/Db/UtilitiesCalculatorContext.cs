using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesCalculator.Dao.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace UtilitiesCalculator.Dao.Db
{
    public class UtilitiesCalculatorContext:DbContext
    {
        public UtilitiesCalculatorContext():base("UtilitiesCalculatorContext")
        {
        }
        public DbSet<Reading> Readings { get; set; }
        public DbSet<Bill> Bills { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
