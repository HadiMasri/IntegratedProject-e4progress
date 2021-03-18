using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace E4Progress.DAL.Repositories
{
    public class Question_TypeRepository : Repository<QuestionType>, IQuestion_TypeRepository
    {
        private E4ProgressDBContext _context;
        private IMapper _mapper;

        public Question_TypeRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<QuestionType_Translation> GetQuestionTypeTranslatedBySelectedLanguage(int SelectedLanguageId)
        {
            var questionType_Translations = _context.QuestionType_Translations.Where(x => x.LanguageId == SelectedLanguageId).ToList();
            return questionType_Translations;
        }
    }
}
