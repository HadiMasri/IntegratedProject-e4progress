using E4Progress.DAL.Entities;
using E4Progress.DAL.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace E4Progress.Service.Controllers
{
    [Route("{culture:culture}/api/[controller]")]
    [ApiController]
    public class QuizQuestionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ILogger<QuizQuestionController> _logger;

        public QuizQuestionController(IUnitOfWork unitOfWork, ILogger<QuizQuestionController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public List<Quiz_Question> GetAll()
        {
            return _unitOfWork.QuizQuestion.GetAll();
        }

        [HttpPost]
        public HttpResponseMessage Add(List<Quiz_Question> quizQuestions)
        {
            if (quizQuestions == null) return null;

            _unitOfWork.QuizQuestion.AddMultiple(quizQuestions);
            _unitOfWork.Save();

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPatch]
        public HttpResponseMessage Update(List<Quiz_Question> quizQuestions)
        {
            if (quizQuestions == null) return null;

            _unitOfWork.QuizQuestion.Update(quizQuestions);
            _unitOfWork.Save();

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPut]
        public HttpResponseMessage Delete(List<Quiz_Question> quizQuestions)
        {
            if (quizQuestions == null) return null;

            _unitOfWork.QuizQuestion.DeleteMultiple(quizQuestions);
            _unitOfWork.Save();

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}