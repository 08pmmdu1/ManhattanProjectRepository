using ManhattanProject.Models.Entities;
using ManhattanProject.Repositories.Mappings;
using System.Data.Entity;

namespace ManhattanProject.Repositories.Contexts
{
    public class UserContext : DbContext
    {
        public UserContext() : base("UserContext")
        {
            Database.SetInitializer<UserContext>(null);
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UserMapping());    
        }
    }
}
