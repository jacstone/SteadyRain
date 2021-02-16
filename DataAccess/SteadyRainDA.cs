using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SteadyRain.Models;
using static SteadyRain.DataAccess.SteadyRainDA;

namespace SteadyRain.DataAccess
{
    public class SteadyRainDA:DbContext
    {

        public SteadyRainDA() : base("SteadyRain")
        {

        }
        
       
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

     

        public System.Data.Entity.DbSet<SteadyRain.Models.StudentModel> StudentModels { get; set; }
        public System.Data.Entity.DbSet<SteadyRain.Models.SchoolModel> SchoolModels { get; set; }
    }
}