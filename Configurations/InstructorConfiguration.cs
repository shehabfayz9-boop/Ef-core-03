using Ef_core_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_03.Configurations
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(
            EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(i => i.Email)
                .IsRequired()
                .HasMaxLength(150);

            builder.HasIndex(i => i.Email)
                .IsUnique();

            builder.Property(i => i.Bio)
                .HasMaxLength(500);

            builder.Property(i => i.JoinDate)
                .IsRequired();

            builder.HasMany(i => i.Courses)
                .WithOne(c => c.Instructor)
                .HasForeignKey(c => c.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasData(
                new Instructor
                {
                    Id = 1,
                    FullName = "Ahmed Mohamed",
                    Email = "ahmed@gmail.com",
                    Bio = "C# Instructor",
                    JoinDate = new DateTime(2024, 1, 10)
                },
                new Instructor
                {
                    Id = 2,
                    FullName = "Sara Ali",
                    Email = "sara@gmail.com",
                    Bio = "Database Instructor",
                    JoinDate = new DateTime(2024, 2, 15)
                },
                new Instructor
                {
                    Id = 3,
                    FullName = "Omar Hassan",
                    Email = "omar@gmail.com",
                    Bio = null,
                    JoinDate = new DateTime(2024, 3, 20)
                }
            );

        }


    }
}
