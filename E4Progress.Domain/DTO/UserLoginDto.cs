using System.ComponentModel.DataAnnotations;

namespace E4Progress.Domain.DTO
{
   public class UserLoginDto
    {
        [Required]
        [StringLength(50)]
        [EmailAddress]

        public string Email { get; set; }
        [Required]
        [StringLength(50)]

        public string Password { get; set; }
    }
}
