using Ef_core_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_03.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(
            EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(s => s.Email)
                .IsRequired()
                .HasMaxLength(150);

            builder.HasIndex(s => s.Email)
                .IsUnique();

            builder.Property(s => s.DateOfBirth)
                .IsRequired();
        }
    }
}