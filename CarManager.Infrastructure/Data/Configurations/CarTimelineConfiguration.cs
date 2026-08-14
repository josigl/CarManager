using CarManager.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarManager.Infrastructure.Data.Configurations
{
    public class CarTimelineConfiguration : IEntityTypeConfiguration<CarTimelineItem>
    {
        public void Configure(EntityTypeBuilder<CarTimelineItem> builder)
        {
            builder.ToTable("CarTimelineItem");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(100);
        }
    }
}
