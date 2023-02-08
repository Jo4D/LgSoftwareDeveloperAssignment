using LgSoftwareDeveloperAssignment.BusinessLayer;

namespace LgSoftwareDeveloperAssignment.PresentationLayer
{
    public class DeviceCreateModel
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public DateTime DeviceAcquisitionDate { get; set; }
        public string DeviceMemo { get; set; }
        public string DeviceSerialNumber { set; get; }
        public string? DeviceHd { get; set; }
        public string DeviceProcessor { get; set; }
        public string DeviceDimensions { set; get; }
        public string DeviceMacAddress { set; get; }
        public string DeviceIpAddress { set; get; }
        public bool IsUsbAllowed { get; set; }
        public int DeviceNetworkSpeed { set; get; }
        public string DeviceOperatingSystem { set; get; }
        public ICollection<string> DevicePorts { set; get; }

        public int DeviceCategoryId { set; get; }
    }
}
