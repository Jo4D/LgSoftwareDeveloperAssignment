using LgSoftwareDeveloperAssignment.BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace LgSoftwareDeveloperAssignment.PresentationLayer.Controllers
{
    public class DeviceCategoriesController : Controller
    {
        private readonly IUnitOfWork uk;
        private long MaxFileSize = 1048576;
        public DeviceCategoriesController(IUnitOfWork _uk)
        {
            uk = _uk;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var device = uk.DeviceCategories.GetAll();
            return View(device);
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var device = uk.DeviceCategories.GetById(id);
            return View(device);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(DeviceCategoryCreateModel model)
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
                uk.DeviceCategories.Add(
                    new DeviceCategory
                    {
                        DeviceCategoryName = model.DeviceCategoryName,
                        DeviceCategoryColor = model.DeviceCategoryColor,
                        DeviceCategoryBrand = model.DeviceCategoryBrand,
                        DeviceCategoryDisplay = model.DeviceCategoryDisplay,
                        Devices = model.Devices
                    }
                    );

                return View();
            }
        }
        [HttpGet]
        public IActionResult Update()
        {
            ViewBag.Title = "All DeviceCategories";
            var devices = uk.DeviceCategories.GetAll();

            return View(devices);
        }
        [HttpPost]
        public IActionResult Update(DeviceCategoryCreateModel model)
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
                uk.DeviceCategories.Update(
                    new DeviceCategory
                    {
                        DeviceCategoryName = model.DeviceCategoryName,
                        DeviceCategoryColor = model.DeviceCategoryColor,
                        DeviceCategoryBrand = model.DeviceCategoryBrand,
                        DeviceCategoryDisplay = model.DeviceCategoryDisplay,
                        Devices = model.Devices
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
            var device = await uk.DeviceCategories.GetById(id);
            uk.DeviceCategories.Delete(device);
            return RedirectToAction("Index");

        }
    }
}
