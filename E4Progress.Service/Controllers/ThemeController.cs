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
    public class ThemeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IStringLocalizer<ThemeController> _localizer;
        private ILogger<ThemeController> _logger;

        public ThemeController(IUnitOfWork unitOfWork, IStringLocalizer<ThemeController> localizer, ILogger<ThemeController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Content_Theme> GetAll()
        {
            var themes = _unitOfWork.Content_Theme.GetAll();

            return themes.ToList();
        }

        [HttpPost]
        public IActionResult Upsert(Content_Theme theme)
        {
            if (theme.Id == 0)
            {
                _unitOfWork.Content_Theme.Add(theme);
                _logger.LogInformation($"New Content_Theme added successfully ! ");
            }
            else
            {
                _unitOfWork.Content_Theme.Update(theme);
                _logger.LogInformation($"Content_Theme updated successfully ! ");
            }
            _unitOfWork.Save();

            return Json(new { success = true, message = " Added Successful" });
        }

        [HttpDelete("{id}")]
        public IActionResult Downsert(int id)
        {
            if (id == 0) return BadRequest();

            _unitOfWork.Content_Theme.Remove(id);
            _unitOfWork.Save();

            return Json(new { success = true, message = " Deleted Successful" });
        }
    }
}
