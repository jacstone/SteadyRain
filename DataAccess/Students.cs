using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SteadyRain.Models;
using static SteadyRain.DataAccess.Schools;

namespace SteadyRain.DataAccess
{
    public class Students:DbContext
    {

        public Students() : base("SteadyRain")
        {

        }
        
        public DbSet<StudentId> StudentIds { get; set; }
        public DbSet<FirstName> FirstNames { get; set; }
        public DbSet<LastName> LastNames { get; set; }
        public DbSet<SchoolId> SchoolIDs { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<IsActive> IsActives { get; set; }
        public DbSet<ZipCode> ZipCodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public class FirstName
        {
        }

        public class StudentId
        {
        }

        public class LastName
        {
        }

        public class Major
        {
        }

        public class IsActive
        {
        }

        public System.Data.Entity.DbSet<SteadyRain.Models.StudentModel> StudentModels { get; set; }
    }
}