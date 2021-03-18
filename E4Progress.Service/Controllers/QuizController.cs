using E4Progress.DAL.Entities;
using E4Progress.DAL.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace E4Progress.Service.Controllers
{
    [Route("{culture:culture}/api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ILogger<QuizController> _logger;

        public QuizController(IUnitOfWork unitOfWork, ILogger<QuizController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpPost]
        public HttpResponseMessage Add(Quiz quiz)
        {
            if (quiz == null) return new HttpResponseMessage(HttpStatusCode.BadRequest);

            _unitOfWork.Quiz.Add(quiz);
            _unitOfWork.Save();

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
        
        [HttpPatch]
        public HttpResponseMessage Update(Quiz quiz)
        {
            if (quiz == null) return new HttpResponseMessage(HttpStatusCode.BadRequest);

            _unitOfWork.Quiz.Update(quiz);
            _unitOfWork.Save();

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpGet]
        public List<Quiz> GetAll()
        {
            return _unitOfWork.Quiz.GetAll().ToList();
        }
    }
}