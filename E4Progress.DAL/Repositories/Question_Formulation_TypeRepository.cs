using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace E4Progress.DAL.Repositories
{
    class Question_Formulation_TypeRepository : Repository<Question_Formulation_Type>, IQuestion_Formulation_TypeRepository
    {
        private E4ProgressDBContext _context;
        private IMapper _mapper;

        public Question_Formulation_TypeRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Question_Formulation_Type_Translation> GetQuestionFormulationTypeTranslatedBySelectedLanguage(int SelectedLanguageId)
        {
            var question_Formulation_Type_Translations = _context.Question_Formulation_Type_Translations.Where(x => x.LanguageId == SelectedLanguageId).ToList();
            return question_Formulation_Type_Translations;
        }
    }
}
