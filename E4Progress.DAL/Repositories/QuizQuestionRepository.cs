using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace E4Progress.DAL.Repositories
{
    class QuizQuestionRepository : Repository<Quiz_Question>, IQuizQuestionRepository
    {
        private E4ProgressDBContext _context;
        private IMapper _mapper;

        public QuizQuestionRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddMultiple(List<Quiz_Question> quizQuestions)
        {
            foreach (Quiz_Question qq in quizQuestions)
            {
                Add(qq);
            }
        }

        public void Update(List<Quiz_Question> quizQuestions)
        {
            Quiz_Question oldQQ;

            foreach (Quiz_Question qq in quizQuestions)
            {
                oldQQ = _context.Quiz_Questions.FirstOrDefault(q => q.Quiz_Id == qq.Quiz_Id && q.Question_Id == qq.Question_Id);
                oldQQ.Sortorder = qq.Sortorder;
            }
        }

        public void DeleteMultiple(List<Quiz_Question> quizQuestions)
        {
            Quiz_Question removedQQ;

            foreach (Quiz_Question qq in quizQuestions)
            {
                removedQQ = dbSet.FirstOrDefault(q => q.Quiz_Id == qq.Quiz_Id && q.Question_Id == qq.Question_Id && q.Sortorder == qq.Sortorder);
                dbSet.Remove(removedQQ);
            }
        }
    }
}