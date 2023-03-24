using System.Data.Entity;

namespace Tecstac_HandsOns.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext() : base("Name = ProjectDB")   
        {
        }       
        public virtual DbSet<Project> Projects { get; set; }
    }
}