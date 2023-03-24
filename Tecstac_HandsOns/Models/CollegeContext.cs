using System.Data.Entity;

namespace Tecstac_HandsOns.Models
{
    public class CollegeContext :DbContext
    {
        public CollegeContext() : base("Name=CollegeContext")        
        {
        }        
        public DbSet<Placement> Placements { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}