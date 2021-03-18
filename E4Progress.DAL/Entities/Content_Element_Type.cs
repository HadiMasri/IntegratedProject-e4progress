using System.Collections.Generic;

namespace E4Progress.DAL.Entities
{
    public class Content_Element_Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course_Module_Topic_Element> Course_Module_Topic_Elements { get; set; }
        public ICollection<Content_Element_Type_Translation> Content_Element_Type_Translations { get; set; }
    }
}
