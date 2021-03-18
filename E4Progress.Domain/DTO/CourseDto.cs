using System;
using System.Collections.Generic;

namespace E4Progress.Domain.DTO
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int Instruction_LanguageId { get; set; }
        public LanguageDto Instruction_Language { get; set; }
        public int UserInterface_LanguageId { get; set; }
        public LanguageDto UserInterface_Language { get; set; }
        public int Office_ApplicationId { get; set; }
        public Office_ApplicationDto Office_Application { get; set; }
        public int Created_By { get; set; }
        public DateTime Created_On { get; set; }
        public string ReplicationKey { get; set; }

        public ICollection<Course_ModuleDto> Course_Modules { get; set; }
    }
}
