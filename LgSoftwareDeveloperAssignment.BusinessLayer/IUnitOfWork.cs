namespace LgSoftwareDeveloperAssignment.BusinessLayer
{
    public interface IUnitOfWork:IDisposable
    {
        IBaseRepository<DeviceCategory> DeviceCategories { get; }
        IBaseRepository<Device> Devices { get; }
        int complete();
    }
}
