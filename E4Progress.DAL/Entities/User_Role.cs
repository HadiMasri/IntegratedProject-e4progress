using System.ComponentModel.DataAnnotations;

namespace E4Progress.DAL.Entities
{
    public class User_Role
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
