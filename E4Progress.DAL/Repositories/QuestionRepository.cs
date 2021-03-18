using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using System.Linq;

namespace E4Progress.DAL.Repositories
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        private E4ProgressDBContext _context;
        private IMapper _mapper;

        public QuestionRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Update(Question questionToUpdate)
        {
            var objFromDb = _context.Questions.FirstOrDefault(s => s.Id == questionToUpdate.Id);
            var question = _mapper.Map<Question>(questionToUpdate);
            if (objFromDb != null)
            {
                objFromDb.Question_TypeId = question.Question_TypeId;
                objFromDb.Question_Formulation_TypeId = question.Question_Formulation_TypeId;
                objFromDb.Instruction_LanguageId = question.Instruction_LanguageId;
                objFromDb.UserInterface_LanguageId = question.UserInterface_LanguageId;
                objFromDb.Office_ApplicationId = question.Office_ApplicationId;
                objFromDb.Notes = question.Notes;
                objFromDb.QuestionText = question.QuestionText;
                objFromDb.ReplicationKey = question.ReplicationKey;
                objFromDb.Version_Number = question.Version_Number;
                objFromDb.Title = question.Title;
                objFromDb.Is_Master_Question = question.Is_Master_Question;
                objFromDb.Master_QuestionId = question.Master_QuestionId;
            }
        }
    }
}
