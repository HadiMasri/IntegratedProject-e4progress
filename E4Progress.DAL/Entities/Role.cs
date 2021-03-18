using System.ComponentModel.DataAnnotations;

namespace E4Progress.DAL.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Display_Label { get; set; }
    }
}
