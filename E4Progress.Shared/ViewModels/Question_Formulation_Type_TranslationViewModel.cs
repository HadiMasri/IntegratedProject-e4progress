using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.Shared.ViewModels
{
    public class Question_Formulation_Type_TranslationViewModel
    {
        public int Id { get; set; }
        public int Question_Formulation_TypeId { get; set; }
        public Question_Formulation_TypeViewModel Question_Formulation_Type { get; set; }
        public int LanguageId { get; set; }
        public LanguageViewModel Language { get; set; }
        public string Translation { get; set; }
    }
}
