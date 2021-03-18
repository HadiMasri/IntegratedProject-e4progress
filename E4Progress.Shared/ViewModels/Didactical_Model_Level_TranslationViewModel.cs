using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.Shared.ViewModels
{
    public class Didactical_Model_Level_TranslationViewModel
    {
        public int Id { get; set; }
        public int Didactical_Model_LevelId { get; set; }
        public Didactical_Model_LevelViewModel Didactical_Model_Level { get; set; }
        public int LanguageId { get; set; }
        public LanguageViewModel Language { get; set; }
        public string Translation { get; set; }
    }
}
