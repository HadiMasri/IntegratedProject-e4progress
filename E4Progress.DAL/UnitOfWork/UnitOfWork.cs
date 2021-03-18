using AutoMapper;
using E4Progress.DAL.IRepositories;
using E4Progress.DAL.IRepository;
using E4Progress.DAL.Repositories;
using Microsoft.Extensions.Configuration;

namespace E4Progress.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private E4ProgressDBContext _context;
        private IMapper _mapper;
        private IConfiguration _configuration;

        public UnitOfWork(E4ProgressDBContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
            User = new UserRepository(_context, _mapper, _configuration);
            Course = new CourseRepository(_context, _mapper);
            Course_Module = new Course_ModuleRepository(_context, _mapper);
            Course_Module_Topic = new Course_Module_TopicRepository(_context, _mapper);
            Course_Module_Topic_Element = new Course_Module_Topic_ElementRepository(_context, _mapper);
            Content_Theme = new Content_ThemeRepository(_context, _mapper);
            UserRole = new UserRoleRepository(_context, _mapper);
            Office_Application = new Office_ApplicationRepository(_context, _mapper);
            Language = new LanguageRepository(_context, _mapper);
            Quiz = new QuizRepository(_context, _mapper);
            QuizQuestion = new QuizQuestionRepository(_context, _mapper);
            Question = new QuestionRepository(_context, _mapper);
            Question_Type = new Question_TypeRepository(_context, _mapper);
            Question_Formulation_Type = new Question_Formulation_TypeRepository(_context, _mapper);
            Question_Content_Theme = new Question_Content_ThemaRepository(_context, _mapper);
            Question_Content_Theme = new Question_Content_ThemaRepository(_context, _mapper);
            Question_Pre_Knowledge_Skill = new Question_Pre_Knowledge_SkillRepository(_context, _mapper);
            Question_Learninggoal = new Question_LearninggoalRepository(_context, _mapper);
            Didactical_Model_Level = new Didactical_Model_LevelRepository(_context, _mapper);
        }

        public IUserRepository User { get; private set; }
        public ICourseRepository Course { get; set; }
        public ICourse_ModuleRepository Course_Module { get; set; }
        public ICourse_Module_TopicRepository Course_Module_Topic { get; set; }
        public ICourse_Module_Topic_ElementRepository Course_Module_Topic_Element { get; set; }
        public IContent_ThemeRepository Content_Theme { get; set; }
        public IQuestion_Content_ThemaRepository Question_Content_Theme { get; set; }
        public IUserRoleRepository UserRole { get; set; }
        public IOffice_ApplicationRepository Office_Application { get; }
        public ILanguageRepository Language { get; }
        public IQuizRepository Quiz { get; set; }
        public IQuizQuestionRepository QuizQuestion { get; set; }
        public IQuestionRepository Question { get; set; }
        public IQuestion_TypeRepository Question_Type { get; set; }
        public IQuestion_Formulation_TypeRepository Question_Formulation_Type { get; set; }
        public IQuestion_Pre_Knowledge_SkillRepository Question_Pre_Knowledge_Skill { get; set; }
        public IQuestion_LearninggoalRepository Question_Learninggoal { get; set; }
        public IDidactical_Model_LevelRepository Didactical_Model_Level { get; set; }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
