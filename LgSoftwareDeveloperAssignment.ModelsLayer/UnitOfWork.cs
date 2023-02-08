using LgSoftwareDeveloperAssignment.BusinessLayer;
using LgSoftwareDeveloperAssignment.ModelsLayer;

namespace LgSoftwareDeveloperAssignment.DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        public IBaseRepository<DeviceCategory> DeviceCategories { get; private set; }

        public IBaseRepository<Device> Devices { get; private set; }
        public UnitOfWork(ApplicationDbContext _context)
        {
          context= _context;
            Devices = new BaseRepository<Device>(context);
            DeviceCategories = new BaseRepository<DeviceCategory>(context);
        }

        public int complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
           context.Dispose();
        }
    }
}
