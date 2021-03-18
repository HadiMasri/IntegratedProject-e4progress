using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using E4Progress.DAL.Entities;
using E4Progress.DAL.UnitOfWork;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace E4Progress.Service.Controllers
{
    [Route("{culture:culture}/api/[controller]")]
    [ApiController]
    public class ElementController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IStringLocalizer<ElementController> _localizer;
        private ILogger<ElementController> _logger;

        public ElementController(IUnitOfWork unitOfWork, IStringLocalizer<ElementController> localizer, ILogger<ElementController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Course_Module_Topic_Element> GetAll()
        {
            var elements = _unitOfWork.Course_Module_Topic_Element.GetAll();

            return elements;
        }

        [HttpPost]
        public IActionResult Upsert(Course_Module_Topic_Element element)
        {
            if (element.Id == 0)
            {
                _unitOfWork.Course_Module_Topic_Element.Add(element);
                _logger.LogInformation($"New Element added successfully ! ");
            }
            else
            {
                _unitOfWork.Course_Module_Topic_Element.Update(element);
                _logger.LogInformation($"New Element added successfully ! ");
            }
            _unitOfWork.Save();
            return Json(new { success = true, message = " Added Successful" });
        }

        [HttpDelete("{id}")]
        public IActionResult Downsert(int id)
        {
            if (id == 0) return BadRequest();

            _unitOfWork.Course_Module_Topic_Element.Remove(id);
            _unitOfWork.Save();
            return Json(new { success = true, message = " Deleted Successful" });
        }
    }
}
