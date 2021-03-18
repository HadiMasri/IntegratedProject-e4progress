using System;
using System.Collections.Generic;

namespace E4Progress.Shared.ViewModels
{
   public class CourseViewModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public LanguageViewModel Instruction_Language { get; set; }
        public string Instruction_LanguageName { get; set; }
        public LanguageViewModel UserInterface_Language { get; set; }
        public string UserInterface_LanguageName { get; set; }
        public int Office_Application_Id { get; set; }
        public Office_ApplicationViewModel Office_Application { get; set; }
        public string Office_ApplicationName { get; set; }
        public int Created_By { get; set; }
        public int ModuleNumbers { get; set; }
        public int TopicsNumbers { get; set; }
        public DateTime Created_On { get; set; }
        public string ReplicationKey { get; set; }
        public int Instruction_LanguageId { get; set; }
        public int UserInterface_LanguageId { get; set; }

        public ICollection<Course_ModuleViewModel>? Course_Modules { get; set; }

    }
}
