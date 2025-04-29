using Crud.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud.Core
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EmployeeTbl");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.EmpCode).IsRequired().HasMaxLength(50);
                entity.Property(e => e.EmpName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.UserLogId).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Password).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Role).IsRequired().HasMaxLength(50);
                entity.Property(e => e.EmailAddress).IsRequired().HasMaxLength(100);
                entity.Property(e => e.CreateDateTime).IsRequired();
                // BaseEntity properties
                entity.Property(e => e.CreatedBy).HasMaxLength(100);
                entity.Property(e => e.CreatedDate);
                entity.Property(e => e.DeletedBy).HasMaxLength(100);
                entity.Property(e => e.DeletedDate);
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });
        }

    }
}
