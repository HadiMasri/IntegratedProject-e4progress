using System;

namespace E4Progress.UI.ViewModelsdata
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Instruction_Language { get; set; }
        public string UserInterface_Language { get; set; }
        public int Office_Application_Id { get; set; }
        public string Office_Application { get; set; }
        public int Created_By { get; set; }
        public int ModuleNumbers { get; set; }
        public int TopicsNumbers { get; set; }
        public DateTime Created_On { get; set; }
        public string ReplicationKey { get; set; }
        public int Instruction_LanguageId { get; set; }
        public int UserInterface_LanguageId { get; set; }
    }
}
