namespace E4Progress.Domain.DTO
{
  public  class UserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int RoleId { get; set; }
    }
}
