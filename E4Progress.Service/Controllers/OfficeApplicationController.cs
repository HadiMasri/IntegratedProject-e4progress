using System;
using System.Collections.Generic;
using System.Linq;
using E4Progress.DAL.Entities;
using E4Progress.DAL.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace E4Progress.Service.Controllers
{
    [Route("{culture:culture}/api/[controller]")]
    [ApiController]
    public class OfficeApplicationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private ILogger<OfficeApplicationController> _logger;

        public OfficeApplicationController(IUnitOfWork unitOfWork, ILogger<OfficeApplicationController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Office_Application> GetAll()
        {
            try
            {
                var allObj = _unitOfWork.Office_Application.GetAll();
                _logger.LogInformation($"Get All Office Application");

                return allObj.ToList();
            }
            catch (Exception ex)
            {

                _logger.LogError($"An error occurred while trying to Get all Office applications");
                throw new Exception(ex.Message);
            }
        }
    }
}
