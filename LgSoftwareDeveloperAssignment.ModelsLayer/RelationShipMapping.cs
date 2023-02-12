using LgSoftwareDeveloperAssignment.BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace LgSoftwareDeveloperAssignment.DataLayer
{
    public static class RelationShipMapping
    {
        public static void MapRelationShips(this ModelBuilder builder)
        {
            builder.Entity<Device>()
                .HasOne(c => c.DeviceCategory)
                .WithMany(d=>d.Devices).HasForeignKey(d => d.DeviceCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
