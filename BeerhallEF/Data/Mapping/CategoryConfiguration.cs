using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerhallEF.Data.Mapping
{
    class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            #region Table
            builder.ToTable("Category");
            #endregion

            #region Properties
            builder.Property(t => t.Name)
                    .HasMaxLength(100)
                    .IsRequired();

            builder.Ignore(t => t.Brewers);
            #endregion

        }
    }
}