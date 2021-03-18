using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.Shared.ViewModels
{
    public class Question_LearninggoalViewModel
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public QuestionViewModel Question { get; set; }
        public int Didactical_Model_LevelId { get; set; }
        public string Learninggoal { get; set; }
        public bool Is_Measurable { get; set; }
        public string Notes { get; set; }
        public int Sortorder { get; set; }
    }
}
