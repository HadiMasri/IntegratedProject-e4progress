using System.Collections.Generic;

namespace E4Progress.DAL.Entities
{
    public class Difficulty_Level
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }

        public ICollection<Course_Module_Topic_Element> Course_Module_Topic_Elements { get; set; }
        public ICollection<Difficulty_Level_Translation> Difficulty_Level_Translations { get; set; }
    }
}
