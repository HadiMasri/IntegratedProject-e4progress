using E4Progress.DAL.IRepositories;
using E4Progress.DAL.IRepository;
using System;

namespace E4Progress.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository User { get; }
        ICourseRepository Course { get; }
        ICourse_ModuleRepository Course_Module { get; }
        ICourse_Module_TopicRepository Course_Module_Topic { get; }
        IQuizRepository Quiz { get; }
        IQuizQuestionRepository QuizQuestion { get; set; }
        ICourse_Module_Topic_ElementRepository Course_Module_Topic_Element { get;  }
        IContent_ThemeRepository Content_Theme { get; }
        IQuestion_Content_ThemaRepository Question_Content_Theme { get; }
        IQuestion_LearninggoalRepository Question_Learninggoal { get; }
        IQuestion_Pre_Knowledge_SkillRepository Question_Pre_Knowledge_Skill { get; }
        IUserRoleRepository UserRole { get; }
        IOffice_ApplicationRepository Office_Application { get; }
        ILanguageRepository Language { get; }
        IQuestionRepository Question { get; }
        IQuestion_TypeRepository Question_Type { get; }
        IQuestion_Formulation_TypeRepository Question_Formulation_Type { get; }
        IDidactical_Model_LevelRepository Didactical_Model_Level { get; }
        int Save();
    }
}