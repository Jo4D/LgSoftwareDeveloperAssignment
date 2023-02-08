using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LgSoftwareDeveloperAssignment.BusinessLayer
{
    public class DeviceCategory
    {
        public int DeviceCategoryId { get; set; }
        public string DeviceCategoryName { get; set;}
        public string DeviceCategoryColor { get; set;}
        public string DeviceCategoryBrand { get; set;}
        public bool DeviceCategoryDisplay { get; set;}
        public virtual ICollection<Device> Devices { get; set;}

    }
}
