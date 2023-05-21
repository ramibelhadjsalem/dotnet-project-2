using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Nakia_amal.Models
{
    public class DataContext : IdentityDbContext<User, Role, int>
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        public virtual DbSet<Action> Actions { get; set; }

        public virtual DbSet<Reclamation> Reclamations { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Name=ConnectionStrings:HelpDeskCs");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                 .HasOne(u => u.Role)
                 .WithMany(r => r.Users)
                 .HasForeignKey(ur => ur.RoleId)
                 .IsRequired()
                 .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
