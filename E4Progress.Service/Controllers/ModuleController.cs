using System.Collections.Generic;
using System.Linq;
using E4Progress.DAL.Entities;
using E4Progress.DAL.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace E4Progress.Service.Controllers
{
    [Route("{culture:culture}/api/[controller]")]
    [ApiController]
    public class ModuleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IStringLocalizer<ModuleController> _localizer;
        private ILogger<ModuleController> _logger;

        public ModuleController(IUnitOfWork unitOfWork, IStringLocalizer<ModuleController> localizer, ILogger<ModuleController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Course_Module> GetAll()
        {
            var modules = _unitOfWork.Course_Module.GetAll();

            return modules.ToList();
        }

        [HttpPost]
        public IActionResult Upsert(Course_Module module)
        {
            if (module.Id == 0)
            {
                _unitOfWork.Course_Module.Add(module);
                _logger.LogInformation($"New module added successfully ! ");
            }
            else
            {
                _unitOfWork.Course_Module.Update(module);
                _logger.LogInformation($"Module updated successfully ! ");
            }
            _unitOfWork.Save();

            return Json(new { success = true, message = " Added Successful" });
        }

        [HttpDelete("{id}")]
        public IActionResult Downsert(int id)
        {
            if (id == 0) return BadRequest();

            _unitOfWork.Course_Module.Remove(id);
            _unitOfWork.Save();

            return Json(new { success = true, message = " Deleted Successful" });
        }
    }
}
