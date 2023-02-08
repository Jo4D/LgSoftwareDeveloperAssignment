using LgSoftwareDeveloperAssignment.BusinessLayer;
using LgSoftwareDeveloperAssignment.DataLayer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace LgSoftwareDeveloperAssignment.ModelsLayer
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
        public DbSet<DeviceCategory> DeviceCategories { get; set; }
        public DbSet<Device> Devices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new DevicesCategoryConfig().Configure(builder.Entity<DeviceCategory>());
            new DevicesConfig().Configure(builder.Entity<Device>());
            builder.MapRelationShips();
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }

}
