using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.Shared.ViewModels
{
    public class Question_Pre_Knowledge_SkillViewModel
    {
        public int Id { get; set; }
        public string Skill { get; set; }
        public int QuestionId { get; set; }
        public QuestionViewModel Question { get; set; }
        public int Sortorder { get; set; }
    }
}
