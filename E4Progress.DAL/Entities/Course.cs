using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace E4Progress.DAL.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int Instruction_LanguageId { get; set; }
        public Language Instruction_Language { get; set; }
        public int UserInterface_LanguageId { get; set; }
        public Language UserInterface_Language { get; set; }
        public int Office_ApplicationId { get; set; }
        public Office_Application Office_Application { get; set; }
        public int Created_By { get; set; }
        public DateTime Created_On { get; set; }
        public string ReplicationKey { get; set; }

        public ICollection<Course_Module> Course_Modules { get; set; }
    }
}
