using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerhallEF.Data.Mapping
{
    class CategoryBrewerConfiguration : IEntityTypeConfiguration<CategoryBrewer>
    {
        public void Configure(EntityTypeBuilder<CategoryBrewer> builder)
        {
            #region Table
            builder.ToTable("CategoryBrewer");
            #endregion

            #region Keys and Indices
            builder.HasKey(t => new { t.CategoryId, t.BrewerId });
            #endregion

            #region associations
            builder.HasOne(t => t.Category)
                    .WithMany(t => t.CategoryBrewers)
                    .HasForeignKey(t => t.CategoryId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(pt => pt.Brewer)
                    .WithMany()
                    .HasForeignKey(pt => pt.BrewerId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}