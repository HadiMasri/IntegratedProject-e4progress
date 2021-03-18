using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using System.Linq;

namespace E4Progress.DAL.Repositories
{
    public class QuizRepository : Repository<Quiz>, IQuizRepository
    {
        private E4ProgressDBContext _context;
        private IMapper _mapper;

        public QuizRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Update(Quiz quiz)
        {
            var objFromDb = _context.Quizzes.FirstOrDefault(quiz => quiz.Id == quiz.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = quiz.Title;
                objFromDb.Office_Application_Id = quiz.Office_Application_Id;
                objFromDb.Instruction_Language_Id = quiz.Instruction_Language_Id;
                objFromDb.Userinterface_Language_Id = quiz.Userinterface_Language_Id;
                objFromDb.Identification_Code = quiz.Identification_Code;
                objFromDb.Short_Intro = quiz.Short_Intro;
                objFromDb.Intro = quiz.Intro;
                objFromDb.Default_Minimum_Score = quiz.Default_Minimum_Score;
                objFromDb.Default_Time_Limit = quiz.Default_Time_Limit;
            }
        }
    }
}