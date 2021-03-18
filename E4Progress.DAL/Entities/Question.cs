using System;
using System.Collections.Generic;

namespace E4Progress.DAL.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public int Question_TypeId { get; set; }
        public QuestionType Question_Type { get; set; }
        public bool Is_Master_Question { get; set; }
        public int? Master_QuestionId { get; set; }
        public Question Master_Question { get; set; }
        public int Instruction_LanguageId { get; set; }
        public Language Instruction_Language { get; set; }
        public int UserInterface_LanguageId { get; set; }
        public Language UserInterface_Language { get; set; }
        public int Question_Formulation_TypeId { get; set; }
        public Question_Formulation_Type Question_Formulation_Type { get; set; }
        public int Office_ApplicationId { get; set; }
        public Office_Application Office_Application { get; set; }
        public string Title { get; set; }
        public string QuestionText { get; set; }
        public DateTime Creation_timestamp  { get; set; }
        public string Notes { get; set; }
        public int Version_Number { get; set; }
        public string ReplicationKey { get; set; }
        public ICollection<Question_Content_Theme> Question_Content_Themes { get; set; }
    }
}
