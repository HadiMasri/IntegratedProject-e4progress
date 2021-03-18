using E4Progress.DAL.Configurations;
using E4Progress.DAL.Entities;
using E4Progress.DAL.Extentions;
using Microsoft.EntityFrameworkCore;

namespace E4Progress.DAL
{
   public class E4ProgressDBContext : DbContext
   {
        public E4ProgressDBContext(DbContextOptions<E4ProgressDBContext> options) : base(options)
        {}

        public DbSet<User> Users { get; set; }
        public DbSet<User_Role> User_Roles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Office_Application> Office_Applications { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Course_Module> Course_Modules { get; set; }
        public DbSet<Course_Module_Topic> Course_Module_Topics { get; set; }
        public DbSet<Course_Module_Topic_Element> Course_Module_Topic_Elements { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Quiz_Question> Quiz_Questions { get; set; }
        public DbSet<Content_Element_Type> Content_Element_Types { get; set; }
        public DbSet<Content_Element_Type_Translation>  Content_Element_Type_Translations { get; set; }
        public DbSet<Didactical_Model_Level>  Didactical_Model_Levels { get; set; }
        public DbSet<Didactical_Model_Level_Translation>   Didactical_Model_Level_Translations { get; set; }
        public DbSet<Didactical_Model>  Didactical_Models { get; set; }
        public DbSet<Didactical_Model_Translation>  Didactical_Model_Translations { get; set; }
        public DbSet<Difficulty_Level>  Difficulty_Levels { get; set; }
        public DbSet<Difficulty_Level_Translation> Difficulty_Level_Translations { get; set; }
        public DbSet<Question_Formulation_Type>  Question_Formulation_Types { get; set; }
        public DbSet<Question_Formulation_Type_Translation>  Question_Formulation_Type_Translations { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Question_Learninggoal> Question_Learninggoals { get; set; }
        public DbSet<Question_Pre_Knowledge_Skill> Question_Pre_Knowledge_Skills { get; set; }
        public DbSet<QuestionType_Translation> QuestionType_Translations { get; set; }
        public DbSet<Language_Translation>  Language_Translations { get; set; }
        public DbSet<Content_Theme> Content_Themes { get; set; }
        public DbSet<Content_Theme_Translation> Content_Theme_Translations { get; set; }
        public DbSet<Question_Content_Theme> Question_Content_Themes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Language_Conf());
            modelBuilder.ApplyConfiguration(new User_Conf());
            modelBuilder.ApplyConfiguration(new Course_Conf());
            modelBuilder.ApplyConfiguration(new User_Role_Conf());
            modelBuilder.ApplyConfiguration(new Role_Conf());
            modelBuilder.ApplyConfiguration(new Office_Application_Conf());
            modelBuilder.ApplyConfiguration(new Course_Module_Conf());
            modelBuilder.ApplyConfiguration(new Course_Module_Topic_Conf());
            modelBuilder.ApplyConfiguration(new Course_Module_Topic_Element_Conf());
            modelBuilder.ApplyConfiguration(new Quiz_Conf());
            modelBuilder.ApplyConfiguration(new Quiz_Question_Conf());
            modelBuilder.ApplyConfiguration(new Content_Element_Type_Conf());
            modelBuilder.ApplyConfiguration(new Content_Element_Type_Translation_Conf());
            modelBuilder.ApplyConfiguration(new Didactical_Model_Level_Conf());
            modelBuilder.ApplyConfiguration(new Didactical_Model_Level_Translation_Conf());
            modelBuilder.ApplyConfiguration(new Didactical_Model_Conf());
            modelBuilder.ApplyConfiguration(new Didactical_Model_Translation_Conf());
            modelBuilder.ApplyConfiguration(new Difficulty_Level_Conf());
            modelBuilder.ApplyConfiguration(new Difficulty_Level_Translation_Conf());
            modelBuilder.ApplyConfiguration(new Question_Formulation_Type_Conf());
            modelBuilder.ApplyConfiguration(new Question_Conf());
            modelBuilder.ApplyConfiguration(new Question_Formulation_Type_Translation_Conf());
            modelBuilder.ApplyConfiguration(new QuestionType_Conf());
            modelBuilder.ApplyConfiguration(new QuestionType_Translation_Conf());
            modelBuilder.ApplyConfiguration(new Language_Translation_Conf());
            modelBuilder.ApplyConfiguration(new Content_Theme_Conf());
            modelBuilder.ApplyConfiguration(new Content_Theme_Translation_Conf());
            modelBuilder.ApplyConfiguration(new Question_Content_Theme_Conf());
            modelBuilder.ApplyConfiguration(new Question_Learninggoal_Conf());
            modelBuilder.ApplyConfiguration(new Question_Pre_Knowledge_Skill_Conf());

            modelBuilder.seed();
        }
   }
}
