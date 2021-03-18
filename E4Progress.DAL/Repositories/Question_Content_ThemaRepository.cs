using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4Progress.DAL.Repositories
{
    public class Question_Content_ThemaRepository : Repository<Question_Content_Theme>, IQuestion_Content_ThemaRepository
    {
        private readonly E4ProgressDBContext _context;
        private readonly IMapper _mapper;

        public Question_Content_ThemaRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Question_Content_Theme> GetQuestionContentThemaByQuestionId(int questionId)
        {
            List<Question_Content_Theme> question_Pre_Knowledge = _context.Question_Content_Themes.Where(x => x.QuestionId == questionId).ToList();
            return question_Pre_Knowledge;
        }
        public void Update(Question_Content_Theme question_Content_Theme)
        {
            var objFromDb = _context.Question_Content_Themes.FirstOrDefault(cm => cm.Id == question_Content_Theme.Id);
            if (objFromDb != null)
            {
                objFromDb.QuestionId = question_Content_Theme.QuestionId;
                objFromDb.Content_ThemeId = question_Content_Theme.Content_ThemeId;
            }
        }
    }
}
