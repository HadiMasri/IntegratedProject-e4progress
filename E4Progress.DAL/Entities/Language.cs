using System.ComponentModel.DataAnnotations;

namespace E4Progress.DAL.Entities
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        public string Native_Name { get; set; }
        public string Code { get; set; }

   
    }
}
