using Ef_core_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_03.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(
            EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Description)
                .HasMaxLength(1000);

            builder.Property(c => c.Price)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(c => c.Level)
                .IsRequired();

            builder.Property(c => c.IsPublished)
                .IsRequired();

            builder.Property(c => c.PublishedDate)
                .IsRequired(false);

            builder.HasOne(c => c.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(c => c.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Category)
                .WithMany(cat => cat.Courses)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasData(
                new Course
                {
                    Id = 1,
                    Title = "C# Basics",
                    Description = "Learn C# fundamentals",
                    Price = 500,
                    Level = CourseLevel.Beginner,
                    IsPublished = true,
                    PublishedDate = new DateTime(2025, 1, 10),
                    InstructorId = 1,
                    CategoryId = 1
                },
                new Course
                {
                    Id = 2,
                    Title = "ASP.NET Core",
                    Description = "Build Web Applications",
                    Price = 1200,
                    Level = CourseLevel.Intermediate,
                    IsPublished = true,
                    PublishedDate = new DateTime(2025, 2, 10),
                    InstructorId = 1,
                    CategoryId = 4
                },
                new Course
                {
                    Id = 3,
                    Title = "SQL Server",
                    Description = "Database Fundamentals",
                    Price = 700,
                    Level = CourseLevel.Beginner,
                    IsPublished = true,
                    PublishedDate = new DateTime(2025, 3, 10),
                    InstructorId = 2,
                    CategoryId = 5
                },
                new Course
                {
                    Id = 4,
                    Title = "Advanced SQL",
                    Description = "Advanced Database Topics",
                    Price = 1500,
                    Level = CourseLevel.Advanced,
                    IsPublished = false,
                    PublishedDate = null,
                    InstructorId = 2,
                    CategoryId = 5
                },
                new Course
                {
                    Id = 5,
                    Title = "HTML and CSS",
                    Description = "Frontend Basics",
                    Price = 400,
                    Level = CourseLevel.Beginner,
                    IsPublished = true,
                    PublishedDate = new DateTime(2025, 4, 10),
                    InstructorId = 3,
                    CategoryId = 3
                },
                new Course
                {
                    Id = 6,
                    Title = "JavaScript Advanced",
                    Description = "Advanced JavaScript",
                    Price = 900,
                    Level = CourseLevel.Advanced,
                    IsPublished = false,
                    PublishedDate = null,
                    InstructorId = 3,
                    CategoryId = 3
                }
            );

        }
    }
}