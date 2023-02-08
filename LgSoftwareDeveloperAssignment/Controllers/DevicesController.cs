using LgSoftwareDeveloperAssignment.BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace LgSoftwareDeveloperAssignment.PresentationLayer
{
    public class DevicesController : Controller
    {
        private readonly IUnitOfWork uk;
        private long MaxFileSize = 1048576;
        public DevicesController(IUnitOfWork _uk)
        {
            uk = _uk;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var device = uk.Devices.GetAll();
            return View(device);
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var device = uk.Devices.GetById(id);
            return View(device);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(DeviceCreateModel model)
        {
            if (ModelState.IsValid == false)
            {
                var errors =
                     ModelState.SelectMany(i => i.Value.Errors.Select(x => x.ErrorMessage));

                foreach (string err in errors)
                    ModelState.AddModelError("", err);

                return View();
            }
            else
            {
                uk.Devices.Add(
                    new Device {
                        DeviceName = model.DeviceName,
                        DeviceAcquisitionDate =model.DeviceAcquisitionDate,
                        DeviceDimensions =model.DeviceDimensions,
                        DeviceHd = model.DeviceHd,
                        DeviceIpAddress = model.DeviceIpAddress,
                        DeviceMacAddress = model.DeviceMacAddress,
                        DeviceOperatingSystem = model.DeviceOperatingSystem,
                        DeviceMemo = model.DeviceMemo,
                        DeviceNetworkSpeed = model.DeviceNetworkSpeed,
                        DeviceProcessor = model.DeviceProcessor,
                        IsUsbAllowed = model.IsUsbAllowed,
                        DeviceSerialNumber = model.DeviceSerialNumber,
                        DevicePorts = model.DevicePorts ,
                    }
                    );
               
                return View();
            }
        }
        [HttpGet]
        public IActionResult Update()
        {
            ViewBag.Title = "All Devices";
            var devices = uk.Devices.GetAll();

            return View(devices);
        }
        [HttpPost]
        public  IActionResult Update(DeviceCreateModel model)
        {
            if (ModelState.IsValid == false)
            {
                var errors =
                     ModelState.SelectMany(i => i.Value.Errors.Select(x => x.ErrorMessage));

                foreach (string err in errors)
                    ModelState.AddModelError("", err);

                return View();
            }
            else
            {
                uk.Devices.Update(
                    new Device
                    {
                        DeviceName = model.DeviceName,
                        DeviceAcquisitionDate = model.DeviceAcquisitionDate,
                        DeviceDimensions = model.DeviceDimensions,
                        DeviceHd = model.DeviceHd,
                        DeviceIpAddress = model.DeviceIpAddress,
                        DeviceMacAddress = model.DeviceMacAddress,
                        DeviceOperatingSystem = model.DeviceOperatingSystem,
                        DeviceMemo = model.DeviceMemo,
                        DeviceNetworkSpeed = model.DeviceNetworkSpeed,
                        DeviceProcessor = model.DeviceProcessor,
                        IsUsbAllowed = model.IsUsbAllowed,
                        DeviceSerialNumber = model.DeviceSerialNumber,
                        DevicePorts = model.DevicePorts,
                    }
                    );

                return View();
            }
        }
        [HttpGet]
        public IActionResult ConfirmDelete(int id, string Name)
        {
            dynamic device = new ExpandoObject();
            device.Name = Name;
            device.ID = id;
            return View(device);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var device =await uk.Devices.GetById(id);
            uk.Devices.Delete(device);
            return RedirectToAction("Index");
            
        }
    }
}
