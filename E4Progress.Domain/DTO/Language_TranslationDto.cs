namespace E4Progress.Domain.DTO
{
   public class Language_TranslationDto
    {
        public int LanguageId { get; set; }
        public LanguageDto Language { get; set; }
        public int Translation_LanguageId { get; set; }
        public LanguageDto Translation_Language { get; set; }

        public string Translation { get; set; }
    }
}
