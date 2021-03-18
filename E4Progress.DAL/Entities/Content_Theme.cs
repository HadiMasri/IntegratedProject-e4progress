using System.Collections.Generic;

namespace E4Progress.DAL.Entities
{
    public class Content_Theme
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Content_Theme_Translation> Content_Theme_Translations { get; set; }
        public ICollection<Question_Content_Theme> Question_Content_Themes { get; set; }
    }
}
