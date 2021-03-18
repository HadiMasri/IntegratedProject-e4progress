namespace E4Progress.DAL.Entities
{
    public class Language_Translation
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int Translation_LanguageId { get; set; }
        public Language Translation_Language { get; set; }
  
        public string Translation { get; set; }
    }
}
