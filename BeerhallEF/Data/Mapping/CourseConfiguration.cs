using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Data.Mapping
{
    class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            #region Table
            builder.ToTable("Course");
            #endregion

            #region Properties
            builder.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(100);
            #endregion

        }
    }
}
