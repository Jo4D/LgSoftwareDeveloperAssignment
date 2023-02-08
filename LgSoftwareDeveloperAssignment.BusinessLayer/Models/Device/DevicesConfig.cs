using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LgSoftwareDeveloperAssignment.BusinessLayer
{
    public class DevicesConfig : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.ToTable(nameof(Device));
            builder.HasKey(i => i.DeviceId);
            builder.Property(i => i.DeviceId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(n => n.DeviceName).IsRequired().HasMaxLength(50);
            builder.Property(d => d.DeviceAcquisitionDate).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.DeviceMemo).IsRequired().HasMaxLength(50);
            builder.Property(s => s.DeviceSerialNumber).IsRequired().HasMaxLength(100);
            builder.Property(h => h.DeviceHd).HasMaxLength(50);
            builder.Property(p => p.DeviceProcessor).IsRequired().HasMaxLength(50);
            builder.Property(d => d.DeviceDimensions).IsRequired().HasMaxLength(50);
            builder.Property(m => m.DeviceMacAddress).IsRequired().HasMaxLength(50);
            builder.Property(ip => ip.DeviceIpAddress).IsRequired().HasMaxLength(50);
            builder.Property(a => a.IsUsbAllowed).HasDefaultValue(true);
            builder.Property(s => s.DeviceNetworkSpeed).IsRequired();
            builder.Property(o => o.DeviceOperatingSystem).IsRequired().HasMaxLength(100);
            builder.Property(p => p.DevicePorts).IsRequired();
                builder
            .Property(p => p.DevicePorts)
            .HasConversion(
                v => string.Join(',', v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
            builder.Property(d => d.DeviceCategoryId).IsRequired();
    }
    }
}
