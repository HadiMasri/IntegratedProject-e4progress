using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.Shared.ViewModels
{
  public class Course_Module_TopicViewModel
    {
        public int Id { get; set; }
        public Course_ModuleViewModel Course_Module { get; set; }
        public int Course_ModuleId { get; set; }
        public string Title { get; set; }
        public int Sortorder { get; set; }
    }
}
