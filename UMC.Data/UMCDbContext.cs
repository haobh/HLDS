using System.Data.Entity;
using UMC.Model.Models;

namespace UMC.Data
{
    public class UMCDbContext : DbContext
    {
        public UMCDbContext() : base("HLDS")
        {
            this.Configuration.LazyLoadingEnabled = true;
            //Database.SetInitializer<UMCDbContext>(null);
        }

        public DbSet<Line> Lines { set; get; }
        public DbSet<Shift> Shifts { set; get; }

        public static UMCDbContext Create()
        {
            return new UMCDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}