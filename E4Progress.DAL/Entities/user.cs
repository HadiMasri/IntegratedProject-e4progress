namespace E4Progress.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public Language language { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
 