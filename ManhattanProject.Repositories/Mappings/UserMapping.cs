using ManhattanProject.Models.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ManhattanProject.Repositories.Mappings
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            this.ToTable("Users");

            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasColumnName("id");

            this.Property(p => p.Login).HasColumnName("login");

            this.Property(p => p.Name).HasColumnName("name");

            this.Property(p => p.Email).HasColumnName("email");

        }
    }
}
