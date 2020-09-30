using Microsoft.EntityFrameworkCore;
using IndeavorTest.Models;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace IndeavorTest.Data
{
    public class IndeavorTestContext : DbContext
    {
        public IndeavorTestContext(DbContextOptions<IndeavorTestContext> options)
            : base(options)
        {
        }

        // Manually controlling changes to database
        public override Task<int> SaveChangesAsync(
    bool acceptAllChangesOnSuccess,
    System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            var AddedEntities = ChangeTracker.Entries()
                .Where(E => E.State == EntityState.Added)
                .ToList();

            AddedEntities.ForEach(E =>
            {
                if (E.Entity is Skill)
                {
                    E.Property("CreationDate").CurrentValue = DateTime.Now;    /// If skill entity is  created, creation time is current time
                }
                    
            });


            var EditedEntities = ChangeTracker.Entries()
        .Where(E => E.State == EntityState.Modified)
        .ToList();

            EditedEntities.ForEach(E =>
            {
                if (E.Entity is Skill)
                {
                    E.Property("CreationDate").IsModified = false;              // If skill entity is modified, don't change the creation date
                }
            });
            
            
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
            
        }

        // On Model Creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().ToTable("Skill");
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }


        public DbSet<Skill> Skill { get; set; }

        public DbSet<Employee> Employee { get; set; }
    }
}