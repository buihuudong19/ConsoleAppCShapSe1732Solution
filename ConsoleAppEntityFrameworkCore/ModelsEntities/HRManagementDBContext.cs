using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleAppEntityFrameworkCore.ModelsEntities
{
    public partial class HRManagementDBContext : DbContext
    {
        public HRManagementDBContext()
        {
        }

        public HRManagementDBContext(DbContextOptions<HRManagementDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("server =(local); database = HRManagementDB;uid=sa;pwd=sa;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Name).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
