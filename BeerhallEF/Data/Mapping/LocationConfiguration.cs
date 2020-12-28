using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Data.Mapping
{
    class LocationConfiguration: IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            #region Table
            builder.ToTable("Location");
            #endregion

            #region Keys and Indices
            // builder.Ignore(t => t.ContactEmail);
            builder.HasKey(l => l.PostalCode); //map primary key
            #endregion

            //properties
            #region Properties
            builder.Property(l => l.PostalCode)
                .HasMaxLength(5);

            builder.Property(l => l.Name)
                .HasMaxLength(100)
                .IsRequired();
            #endregion
        }
    }
}
