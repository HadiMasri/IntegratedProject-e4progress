using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.Shared.ViewModels
{
    public class Course_Module_Topic_ElementViewModel
    {
        public int Id { get; set; }
       // public Content_Element_Type Content_Element_Type { get; set; }
        public int Content_Element_TypeId { get; set; }
        public Course_Module_TopicViewModel Course_Module_Topic { get; set; }
        public int Course_Module_TopicId { get; set; }
        public int Content_ElementId { get; set; }
        //public Difficulty_Level Difficulty_Level { get; set; }
        public int Difficulty_LevelId { get; set; }
        public int Sortorder { get; set; }
    }
}
