using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SteadyRain.Models;

namespace SteadyRain.DataAccess
{
    public class Schools:DbContext
    {
        public Schools():base("SteadyRain")
        {

        }

        public DbSet<SchoolId>  SchoolIds { get; set; }
        public DbSet<SchoolName> SchoolNames { get; set; }
        public DbSet<Address1> Address1s { get; set; }
        public DbSet<Address2> Address2s { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<ZipCode> ZipCodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public class SchoolId
        {
        }

        public class SchoolName
        {
        }

        public class Address1
        {
        }

        public class Address2
        {
        }

        public class City
        {
        }

        public class State
        {
        }

        public class ZipCode
        {
        }

        public System.Data.Entity.DbSet<SteadyRain.Models.SchoolModel> SchoolModels { get; set; }
    }
}