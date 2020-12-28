using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Data.Mapping
{
    class BeerConfiguration : IEntityTypeConfiguration<Beer>
    {
        public void Configure(EntityTypeBuilder<Beer> builder)
        {
            builder.ToTable("Beer");
            // builder.Ignore(t => t.ContactEmail);
            builder.HasKey(t => t.BeerId); //map primary key

            //properties
            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}
