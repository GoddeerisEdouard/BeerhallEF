
using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Data.Mapping
{
    class BrewerConfiguration : IEntityTypeConfiguration<Brewer>
    {
        public void Configure(EntityTypeBuilder<Brewer> builder)
        {
            builder.ToTable("Brewer");
            // builder.Ignore(t => t.ContactEmail);
            builder.HasKey(t => t.BrewerId); //map primary key

            // builder.HasKey(t => new {t.BrewerId, t.ContactEmail}); // voor meerdere keys

            //properties
            #region Properties
            builder.Property(t => t.Name)
                .HasColumnName("BrewerName")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.ContactEmail)
                .HasMaxLength(100);

            builder.Property(t => t.Street)
                .HasMaxLength(100);

            builder.Property(t => t.BrewerId)
                .ValueGeneratedOnAdd();
            #endregion

            #region Associations
            builder.HasMany(t => t.Beers)
                .WithOne()
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Location)
                .WithMany()
                .HasForeignKey(nameof(Location.PostalCode))
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
               #endregion

        }
    }
}
