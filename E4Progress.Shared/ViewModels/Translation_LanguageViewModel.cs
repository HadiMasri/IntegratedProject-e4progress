namespace E4Progress.Shared.ViewModels
{
   public class Translation_LanguageViewModel
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public LanguageViewModel Language { get; set; }
        public int Translation_LanguageId { get; set; }
        public LanguageViewModel Translation_Language { get; set; }
        public string Translation { get; set; }
    }
}
