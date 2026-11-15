using Ef_core_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_03.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(
           EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Description)
                .HasMaxLength(500);

            builder.HasOne(c => c.ParentCategory)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.ParentCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(c => c.Courses)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Programming",
                    Description = "Programming Courses",
                    ParentCategoryId = null
                },
                new Category
                {
                    Id = 2,
                    Name = "Backend",
                    Description = "Backend Development",
                    ParentCategoryId = 1
                },
                new Category
                {
                    Id = 3,
                    Name = "Frontend",
                    Description = "Frontend Development",
                    ParentCategoryId = 1
                },
                new Category
                {
                    Id = 4,
                    Name = "ASP.NET",
                    Description = "ASP.NET Courses",
                    ParentCategoryId = 2
                },
                new Category
                {
                    Id = 5,
                    Name = "Database",
                    Description = "Database Courses",
                    ParentCategoryId = null
                }
            );

        }
    }
}