using Ef_core_03.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_03.Data
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= . ; Database=EFCORE01 ;Trusted_Connection=true; trustservercertificate=true");
        }
        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(AppDbContext).Assembly
            );

            base.OnModelCreating(modelBuilder);
        }

    }


}
