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
    public class TopicController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IStringLocalizer<TopicController> _localizer;
        private ILogger<TopicController> _logger;

        public TopicController(IUnitOfWork unitOfWork, IStringLocalizer<TopicController> localizer, ILogger<TopicController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Course_Module_Topic> GetAll()
        {
            var topics = _unitOfWork.Course_Module_Topic.GetAll();

            return topics;

        }

        [HttpPost]
        public IActionResult Upsert(Course_Module_Topic topic)
        {
            if (topic.Id == 0)
            {
                _unitOfWork.Course_Module_Topic.Add(topic);
                _logger.LogInformation($"New Topic added successfully ! ");
            }
            else
            {
                _unitOfWork.Course_Module_Topic.Update(topic);
                _logger.LogInformation($"New Topic added successfully ! ");
            }
            _unitOfWork.Save();
            return Json(new { success = true, message = " Added Successful" });
        }

        [HttpDelete("{id}")]
        public IActionResult Downsert(int id)
        {
            if (id == 0) return BadRequest();

            _unitOfWork.Course_Module_Topic.Remove(id);
            _unitOfWork.Save();
            return Json(new { success = true, message = " Deleted Successful" });
        }
    }
}
