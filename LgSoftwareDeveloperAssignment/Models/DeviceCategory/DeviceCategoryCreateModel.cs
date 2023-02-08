using LgSoftwareDeveloperAssignment.BusinessLayer;

namespace LgSoftwareDeveloperAssignment.PresentationLayer
{
    public class DeviceCategoryCreateModel
    {
        public string DeviceCategoryName { get; set; }
        public string DeviceCategoryColor { get; set; }
        public string DeviceCategoryBrand { get; set; }
        public bool DeviceCategoryDisplay { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
    }
}
