using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace LgSoftwareDeveloperAssignment.BusinessLayer
{
    public class DevicesCategoryConfig : IEntityTypeConfiguration<DeviceCategory>
    {
        public void Configure(EntityTypeBuilder<DeviceCategory> builder)
        {
            builder.ToTable(nameof(DeviceCategory));
            builder.HasKey(i => i.DeviceCategoryId);
            builder.Property(i=>i.DeviceCategoryId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(i => i.DeviceCategoryName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.DeviceCategoryColor).IsRequired().HasMaxLength(50);
            builder.Property(b => b.DeviceCategoryBrand).IsRequired().HasMaxLength(50);
            builder.Property(d => d.DeviceCategoryDisplay).IsRequired().HasMaxLength(50);
    }
    }
}
