using System;
using System.Collections.Generic;
using System.Text;
using E4Progress.Shared;
namespace E4Progress.Shared.ViewModels
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public int Question_TypeId { get; set; }
        public QuestionTypeViewModel Question_Type { get; set; }
        public string QuestionTypeName { get; set; }
        public bool Is_Master_Question { get; set; }
        public int? Master_QuestionId { get; set; }
        public QuestionViewModel Master_Question { get; set; }
        public int Instruction_LanguageId { get; set; }
        public LanguageViewModel Instruction_Language { get; set; }
        public string InstructionLanguageName { get; set; }
        public int UserInterface_LanguageId { get; set; }
        public LanguageViewModel UserInterface_Language { get; set; }
        public string UserInterfaceLanguageName { get; set; }
        public int Question_Formulation_TypeId { get; set; }
        public Question_Formulation_TypeViewModel Question_Formulation_Type { get; set; }
        public string Question_Formulation_TypeName { get; set; }
        public int Office_ApplicationId { get; set; }
        public Office_ApplicationViewModel Office_Application { get; set; }
        public string OfficeApplicationName { get; set; }
        public string Title { get; set; }

        public string QuestionText { get; set; }
        public DateTime Creation_timestamp { get; set; }
        public string Notes { get; set; }
        public int Version_Number { get; set; }
        public string ReplicationKey { get; set; }
    }
}
