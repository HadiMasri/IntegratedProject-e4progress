using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.Shared.ViewModels
{
    public class QuestionType_TranslationViewModel
    {
        public int Id { get; set; }
        public int QuestionTypeId { get; set; }
        public QuestionTypeViewModel QuestionType { get; set; }
        public int LanguageId { get; set; }
        public LanguageViewModel Language { get; set; }
        public string Translation { get; set; }
    }
}
