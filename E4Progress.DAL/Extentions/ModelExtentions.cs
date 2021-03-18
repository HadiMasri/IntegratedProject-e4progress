using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace E4Progress.DAL.Extentions
{
    public static class ModelExtentions
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            // auto create van tbl_Role with value
            modelBuilder.Entity<Role>().HasData(
                    new Role
                    {
                        Id = 1,
                        Name = "Admin",
                        Display_Label = "Admin"
                    },
                    new Role
                    {
                        Id = 2,
                        Name = "User",
                        Display_Label = "User"
                    }
                );

            // auto create van tbl_languages with value
            modelBuilder.Entity<Language>().HasData(
                      new Language
                      {
                          Id = 1,
                          Native_Name = "English",
                          Code = "EN"
                      },
                      new Language
                      {
                          Id = 2,
                          Native_Name = "Dutch",
                          Code = "NL"
                      },
                      new Language
                      {
                          Id = 3,
                          Native_Name = "French",
                          Code = "FR"
                      }
                );

            // auto create van tbl_languages_translations with value
            modelBuilder.Entity<Language_Translation>().HasData(
                new Language_Translation { Id = 1, LanguageId = 1, Translation_LanguageId = 2, Translation = "Engels" },
                new Language_Translation { Id = 2, LanguageId = 1, Translation_LanguageId = 3, Translation = "Anglais" },
                new Language_Translation { Id = 3, LanguageId = 2, Translation_LanguageId = 1, Translation = "Dutch" },
                new Language_Translation { Id = 4, LanguageId = 2, Translation_LanguageId = 3, Translation = "Néerlandais" },
                new Language_Translation { Id = 5, LanguageId = 3, Translation_LanguageId = 1, Translation = "French" },
                new Language_Translation { Id = 6, LanguageId = 3, Translation_LanguageId = 2, Translation = "Frans" },
                new Language_Translation { Id = 7, LanguageId = 1, Translation_LanguageId = 1, Translation = "English" },
                new Language_Translation { Id = 8, LanguageId = 2, Translation_LanguageId = 2, Translation = "Nederlands" },
                new Language_Translation { Id = 9, LanguageId = 3, Translation_LanguageId = 3, Translation = "Français" }
             );

            // auto create van tbl_Content_Element_Type with value
            modelBuilder.Entity<Content_Element_Type>().HasData(
                new Content_Element_Type { Id = 1, Name = "Quiz" },
                new Content_Element_Type { Id = 2, Name = "Test yourself" },
                new Content_Element_Type { Id = 3, Name = "Exam business" },
                new Content_Element_Type { Id = 4, Name = "Exam school" },
                new Content_Element_Type { Id = 5, Name = "Lesson fiche" }
             );

            // auto create van Content_Element_Type_Translation with value
            modelBuilder.Entity<Content_Element_Type_Translation>().HasData(
                new Content_Element_Type_Translation { Id = 1, Content_Element_TypeId = 1, LanguageId = 1, Translation = "Quiz" },
                new Content_Element_Type_Translation { Id = 2, Content_Element_TypeId = 1, LanguageId = 2, Translation = "Quiz" },
                new Content_Element_Type_Translation { Id = 3, Content_Element_TypeId = 1, LanguageId = 3, Translation = "Quiz" },
                new Content_Element_Type_Translation { Id = 4, Content_Element_TypeId = 2, LanguageId = 1, Translation = "Test yourself" },
                new Content_Element_Type_Translation { Id = 5, Content_Element_TypeId = 2, LanguageId = 2, Translation = "Toets jezelf" },
                new Content_Element_Type_Translation { Id = 6, Content_Element_TypeId = 2, LanguageId = 3, Translation = "Testez vous" },
                new Content_Element_Type_Translation { Id = 7, Content_Element_TypeId = 3, LanguageId = 1, Translation = "Exam business" },
                new Content_Element_Type_Translation { Id = 8, Content_Element_TypeId = 3, LanguageId = 2, Translation = "Examen business" },
                new Content_Element_Type_Translation { Id = 9, Content_Element_TypeId = 3, LanguageId = 3, Translation = "Examen d’entreprise" },
                new Content_Element_Type_Translation { Id = 10, Content_Element_TypeId = 4, LanguageId = 1, Translation = "Exam school" },
                new Content_Element_Type_Translation { Id = 11, Content_Element_TypeId = 4, LanguageId = 2, Translation = "Examen school" },
                new Content_Element_Type_Translation { Id = 12, Content_Element_TypeId = 4, LanguageId = 3, Translation = "Examen scolaire" },
                new Content_Element_Type_Translation { Id = 13, Content_Element_TypeId = 5, LanguageId = 1, Translation = "Lesson fiche" },
                new Content_Element_Type_Translation { Id = 14, Content_Element_TypeId = 5, LanguageId = 2, Translation = "Lesfiche" },
                new Content_Element_Type_Translation { Id = 15, Content_Element_TypeId = 5, LanguageId = 3, Translation = "Fiche de cours" }
             );

            // auto create van Didactical_Model with value
            modelBuilder.Entity<Didactical_Model>().HasData(
                new Didactical_Model { Id = 1, Name = "Bloom" },
                new Didactical_Model { Id = 2, Name = "EVA" }
             );

            // auto create van Didactical_Model_Translation with value
            modelBuilder.Entity<Didactical_Model_Translation>().HasData(
                new Didactical_Model_Translation { Id = 1, Didactical_ModelId = 1, LanguageId = 1, Translation = "Bloom's taxonomy" },
                new Didactical_Model_Translation { Id = 2, Didactical_ModelId = 1, LanguageId = 2, Translation = "Taxonomie van Bloom" },
                new Didactical_Model_Translation { Id = 3, Didactical_ModelId = 1, LanguageId = 3, Translation = "Taxonomie de Bloom" },
                new Didactical_Model_Translation { Id = 4, Didactical_ModelId = 2, LanguageId = 1, Translation = "EVA model" },
                new Didactical_Model_Translation { Id = 5, Didactical_ModelId = 2, LanguageId = 2, Translation = "EVA model" },
                new Didactical_Model_Translation { Id = 6, Didactical_ModelId = 2, LanguageId = 3, Translation = "Le Modèle EVA" }
             );

            // auto create van Didactical_Model_Level with value
            modelBuilder.Entity<Didactical_Model_Level>().HasData(
                new Didactical_Model_Level { Id = 1, Didactical_ModelId = 1, Name = "Remember", Sortorder = 1 },
                new Didactical_Model_Level { Id = 2, Didactical_ModelId = 1, Name = "Understand", Sortorder = 2 },
                new Didactical_Model_Level { Id = 3, Didactical_ModelId = 1, Name = "Apply", Sortorder = 3 },
                new Didactical_Model_Level { Id = 4, Didactical_ModelId = 1, Name = "Analyze", Sortorder = 4 },
                new Didactical_Model_Level { Id = 5, Didactical_ModelId = 1, Name = "Evaluate", Sortorder = 5 },
                new Didactical_Model_Level { Id = 6, Didactical_ModelId = 1, Name = "Create", Sortorder = 6 },
                new Didactical_Model_Level { Id = 7, Didactical_ModelId = 2, Name = "Low", Sortorder = 1 },
                new Didactical_Model_Level { Id = 8, Didactical_ModelId = 2, Name = "Average", Sortorder = 2 },
                new Didactical_Model_Level { Id = 9, Didactical_ModelId = 2, Name = "High", Sortorder = 3 }
             );

            // auto create van Didactical_Model_Level_Translation with value
            modelBuilder.Entity<Didactical_Model_Level_Translation>().HasData(
                new Didactical_Model_Level_Translation { Id = 1, Didactical_Model_LevelId = 1, LanguageId = 1, Translation = "Remember" },
                new Didactical_Model_Level_Translation { Id = 2, Didactical_Model_LevelId = 1, LanguageId = 2, Translation = "Onthouden" },
                new Didactical_Model_Level_Translation { Id = 3, Didactical_Model_LevelId = 1, LanguageId = 3, Translation = "Mémoriser" },
                new Didactical_Model_Level_Translation { Id = 4, Didactical_Model_LevelId = 2, LanguageId = 1, Translation = "Understand" },
                new Didactical_Model_Level_Translation { Id = 5, Didactical_Model_LevelId = 2, LanguageId = 2, Translation = "Begrijpen" },
                new Didactical_Model_Level_Translation { Id = 6, Didactical_Model_LevelId = 2, LanguageId = 3, Translation = "Comprendre" },
                new Didactical_Model_Level_Translation { Id = 7, Didactical_Model_LevelId = 3, LanguageId = 1, Translation = "Apply" },
                new Didactical_Model_Level_Translation { Id = 8, Didactical_Model_LevelId = 3, LanguageId = 2, Translation = "Toepassen" },
                new Didactical_Model_Level_Translation { Id = 9, Didactical_Model_LevelId = 3, LanguageId = 3, Translation = "Appliquer" },
                new Didactical_Model_Level_Translation { Id = 10, Didactical_Model_LevelId = 4, LanguageId = 1, Translation = "Analyze" },
                new Didactical_Model_Level_Translation { Id = 11, Didactical_Model_LevelId = 4, LanguageId = 2, Translation = "Analyseren" },
                new Didactical_Model_Level_Translation { Id = 12, Didactical_Model_LevelId = 4, LanguageId = 3, Translation = "Analyser" },
                new Didactical_Model_Level_Translation { Id = 13, Didactical_Model_LevelId = 5, LanguageId = 1, Translation = "Evaluate" },
                new Didactical_Model_Level_Translation { Id = 14, Didactical_Model_LevelId = 5, LanguageId = 2, Translation = "Evalueren" },
                new Didactical_Model_Level_Translation { Id = 15, Didactical_Model_LevelId = 5, LanguageId = 3, Translation = "Evaluer" },
                new Didactical_Model_Level_Translation { Id = 16, Didactical_Model_LevelId = 6, LanguageId = 1, Translation = "Create" },
                new Didactical_Model_Level_Translation { Id = 17, Didactical_Model_LevelId = 6, LanguageId = 2, Translation = "Creëren" },
                new Didactical_Model_Level_Translation { Id = 18, Didactical_Model_LevelId = 6, LanguageId = 3, Translation = "Créer" },
                new Didactical_Model_Level_Translation { Id = 19, Didactical_Model_LevelId = 7, LanguageId = 1, Translation = "Low" },
                new Didactical_Model_Level_Translation { Id = 20, Didactical_Model_LevelId = 7, LanguageId = 2, Translation = "Laag" },
                new Didactical_Model_Level_Translation { Id = 21, Didactical_Model_LevelId = 7, LanguageId = 3, Translation = "Bas" },
                new Didactical_Model_Level_Translation { Id = 22, Didactical_Model_LevelId = 8, LanguageId = 1, Translation = "Average" },
                new Didactical_Model_Level_Translation { Id = 23, Didactical_Model_LevelId = 8, LanguageId = 2, Translation = "Gemiddeld" },
                new Didactical_Model_Level_Translation { Id = 24, Didactical_Model_LevelId = 8, LanguageId = 3, Translation = "Moyenne" },
                new Didactical_Model_Level_Translation { Id = 25, Didactical_Model_LevelId = 9, LanguageId = 1, Translation = "High" },
                new Didactical_Model_Level_Translation { Id = 26, Didactical_Model_LevelId = 9, LanguageId = 2, Translation = "Hoog" },
                new Didactical_Model_Level_Translation { Id = 27, Didactical_Model_LevelId = 9, LanguageId = 3, Translation = "Haute" }
             );

            //// auto create van Difficulty_Level with value
            modelBuilder.Entity<Difficulty_Level>().HasData(
                new Difficulty_Level { Id = 1, Number = 1, Name = "Explorer" },
                new Difficulty_Level { Id = 2, Number = 2, Name = "Adventurer" },
                new Difficulty_Level { Id = 3, Number = 3, Name = "Expert" },
                new Difficulty_Level { Id = 4, Number = 4, Name = "Master" }
             );

            // auto create van Difficulty_Level_Translation with value
            modelBuilder.Entity<Difficulty_Level_Translation>().HasData(
                new Difficulty_Level_Translation { Id = 1, Difficulty_LevelId = 1, LanguageId = 1, Translation = "Explorer" },
                new Difficulty_Level_Translation { Id = 2, Difficulty_LevelId = 2, LanguageId = 2, Translation = "Explorer" },
                new Difficulty_Level_Translation { Id = 3, Difficulty_LevelId = 3, LanguageId = 3, Translation = "Explorer" },
                new Difficulty_Level_Translation { Id = 4, Difficulty_LevelId = 1, LanguageId = 1, Translation = "Adventurer" },
                new Difficulty_Level_Translation { Id = 5, Difficulty_LevelId = 2, LanguageId = 3, Translation = "Adventurer" },
                new Difficulty_Level_Translation { Id = 6, Difficulty_LevelId = 3, LanguageId = 3, Translation = "Aventurier" },
                new Difficulty_Level_Translation { Id = 7, Difficulty_LevelId = 1, LanguageId = 1, Translation = "Expert" },
                new Difficulty_Level_Translation { Id = 8, Difficulty_LevelId = 2, LanguageId = 2, Translation = "Expert" },
                new Difficulty_Level_Translation { Id = 9, Difficulty_LevelId = 3, LanguageId = 3, Translation = "Expert" },
                new Difficulty_Level_Translation { Id = 10, Difficulty_LevelId = 1, LanguageId = 1, Translation = "Master" },
                new Difficulty_Level_Translation { Id = 11, Difficulty_LevelId = 2, LanguageId = 2, Translation = "Master" },
                new Difficulty_Level_Translation { Id = 12, Difficulty_LevelId = 3, LanguageId = 3, Translation = "Maître" }
             );

            // auto create van Office_Application with value
            modelBuilder.Entity<Office_Application>().HasData(
                new Office_Application { Id = 1, Name = "Access" },
                new Office_Application { Id = 2, Name = "Excel" },
                new Office_Application { Id = 3, Name = "OneNote" },
                new Office_Application { Id = 4, Name = "Outlook" },
                new Office_Application { Id = 5, Name = "PowerPoint" },
                new Office_Application { Id = 6, Name = "Word" }
             );

            // auto create van Office_Application with value
            modelBuilder.Entity<Question_Formulation_Type>().HasData(
                new Question_Formulation_Type { Id = 1, Name = "Open" },
                new Question_Formulation_Type { Id = 2, Name = "Semi-open" },
                new Question_Formulation_Type { Id = 3, Name = "Closed" }
             );

            // auto create van Office_Application with value
            modelBuilder.Entity<Question_Formulation_Type_Translation>().HasData(
                new Question_Formulation_Type_Translation { Id = 1, Question_Formulation_TypeId = 1, LanguageId = 1, Translation = "Open" },
                new Question_Formulation_Type_Translation { Id = 2, Question_Formulation_TypeId = 1, LanguageId = 2, Translation = "Open" },
                new Question_Formulation_Type_Translation { Id = 3, Question_Formulation_TypeId = 1, LanguageId = 3, Translation = "Ouverte" },
                new Question_Formulation_Type_Translation { Id = 4, Question_Formulation_TypeId = 2, LanguageId = 1, Translation = "Semi-open" },
                new Question_Formulation_Type_Translation { Id = 5, Question_Formulation_TypeId = 2, LanguageId = 2, Translation = "Half-open" },
                new Question_Formulation_Type_Translation { Id = 6, Question_Formulation_TypeId = 2, LanguageId = 3, Translation = "Semi-ouverte" },
                new Question_Formulation_Type_Translation { Id = 7, Question_Formulation_TypeId = 3, LanguageId = 1, Translation = "Closed" },
                new Question_Formulation_Type_Translation { Id = 8, Question_Formulation_TypeId = 3, LanguageId = 2, Translation = "Gesloten" },
                new Question_Formulation_Type_Translation { Id = 9, Question_Formulation_TypeId = 3, LanguageId = 3, Translation = "Fermée" }
             );

            // auto create van QuestionType with value
            modelBuilder.Entity<QuestionType>().HasData(
                new QuestionType { Id = 1, Name = "True/false question" }
             );

            // auto create van QuestionType with value
            modelBuilder.Entity<QuestionType_Translation>().HasData(
                new QuestionType_Translation { Id = 1, QuestionTypeId = 1, LanguageId = 1, Translation = "True/false question" },
                new QuestionType_Translation { Id = 2, QuestionTypeId = 1, LanguageId = 2, Translation = "Waar/onwaar vraag" },
                new QuestionType_Translation { Id = 3, QuestionTypeId = 1, LanguageId = 3, Translation = "Vrai/faux question" }
             );

            // auto create van Course with value
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1,Name="Algebra",Icon="",Instruction_LanguageId=1,UserInterface_LanguageId=1,Office_ApplicationId=1,Created_By=1,Created_On=DateTime.Now,ReplicationKey="EF101" },
                new Course { Id = 2, Name = "Yaman", Icon = "", Instruction_LanguageId = 1, UserInterface_LanguageId = 1, Office_ApplicationId = 1, Created_By = 1, Created_On = DateTime.Now, ReplicationKey = "EF102" },
                new Course { Id = 3, Name = "Arabic", Icon = "", Instruction_LanguageId = 1, UserInterface_LanguageId = 1, Office_ApplicationId = 1, Created_By = 1, Created_On = DateTime.Now, ReplicationKey = "EF103" }
                );

            // auto create van Course with value
            modelBuilder.Entity<Course_Module>().HasData(
                new Course_Module { Id = 1, CourseId = 1, Title = "Part One", Sortorder = 1 },
                 new Course_Module { Id = 2, CourseId = 1, Title = "Part Two", Sortorder = 1 },
                 new Course_Module { Id = 3, CourseId = 2, Title = "Part Three", Sortorder = 1 },
                 new Course_Module { Id = 4, CourseId = 2, Title = "Part Four", Sortorder = 1 }
                );

            // auto create van Course with value
            modelBuilder.Entity<Course_Module_Topic>().HasData(
                new Course_Module_Topic { Id = 1, Course_ModuleId = 1, Title = "Multiply", Sortorder = 1 },
                new Course_Module_Topic { Id = 2, Course_ModuleId = 1, Title = "Divide", Sortorder = 2 },
                new Course_Module_Topic { Id = 3, Course_ModuleId = 1, Title = "Power", Sortorder = 3 },
                 new Course_Module_Topic { Id = 4, Course_ModuleId = 2, Title = "jon", Sortorder = 1 },
                new Course_Module_Topic { Id = 5, Course_ModuleId = 2, Title = "nick ", Sortorder =4 },
                new Course_Module_Topic { Id = 6, Course_ModuleId = 3, Title = "brick", Sortorder = 5 }
                );

            // auto create van Course with value
            modelBuilder.Entity<Course_Module_Topic_Element>().HasData(
                new Course_Module_Topic_Element { Id = 1, Content_Element_TypeId = 1, Course_Module_TopicId=1,Content_ElementId=1,Difficulty_LevelId=1, Sortorder = 1 },
                new Course_Module_Topic_Element { Id = 2, Content_Element_TypeId = 1, Course_Module_TopicId = 1, Content_ElementId = 2, Difficulty_LevelId = 1, Sortorder = 1 },
                new Course_Module_Topic_Element { Id = 3, Content_Element_TypeId = 1, Course_Module_TopicId = 2, Content_ElementId = 3, Difficulty_LevelId = 1, Sortorder = 1 }
                );

            modelBuilder.Entity<Content_Theme>().HasData(
                new Content_Theme { Id=1, Name="Medieval"},
                new Content_Theme { Id = 2, Name = "Halloween" });
            /*
            modelBuilder.Entity<Question_Content_Theme>().HasData(
                new Question_Content_Theme { QuestionId = 1, Content_ThemeId = 1 },
                new Question_Content_Theme { QuestionId = 2, Content_ThemeId = 1 },
                new Question_Content_Theme { QuestionId = 3, Content_ThemeId = 2 },
                new Question_Content_Theme { QuestionId = 4, Content_ThemeId = 2 });*/
        }
    }
}
