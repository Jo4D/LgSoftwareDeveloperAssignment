using LgSoftwareDeveloperAssignment.BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
