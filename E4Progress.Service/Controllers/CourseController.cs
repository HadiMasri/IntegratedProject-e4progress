using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using E4Progress.DAL.Entities;
using E4Progress.DAL.UnitOfWork;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;

namespace E4Progress.Service.Controllers
{
    [Route("{culture:culture}/api/[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IStringLocalizer<CourseController> _localizer;
        private ILogger<CourseController> _logger;

        public CourseController(IUnitOfWork unitOfWork, IStringLocalizer<CourseController> localizer, ILogger<CourseController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Course> GetAll()
        {
            try
            {
                var allObj = _unitOfWork.Course.GetAll(I => I.Instruction_Language, a => a.Office_Application, c => c.UserInterface_Language);
                return allObj.ToList();
            }
            catch (Exception)
            {
                _logger.LogError($"An error occurred while trying to get all Courses");
                throw;

            }
               
        }

        [HttpPost]
        public IActionResult Upsert(Course course)
        {
            try
            {
                if (course.Id == 0)
                {
                    _unitOfWork.Course.Add(course);
                    _logger.LogInformation($"New Cource added successfully ! ");
                }
                else
                {
                    _unitOfWork.Course.Update(course);
                    _logger.LogInformation($"Cource updated successfully ! ");
                }

                _unitOfWork.Save();
                return Json(new { success = true, message = " Added Successful" });
            }
            catch (Exception)
            {

                _logger.LogError($"An error occurred while trying to Add Or update Course");
                throw;
            }
           
        }
    }
}
