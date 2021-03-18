using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;
using System.Collections.Generic;

namespace E4Progress.DAL.IRepositories
{
    public interface IQuizQuestionRepository : IRepository<Quiz_Question>
    {
        void AddMultiple(List<Quiz_Question> quizQuestions);
        void Update(List<Quiz_Question> quizQuestions);
        void DeleteMultiple(List<Quiz_Question> quizQuestions);
    }
}
