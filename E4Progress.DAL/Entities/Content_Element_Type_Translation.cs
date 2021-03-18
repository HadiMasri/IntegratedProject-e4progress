namespace E4Progress.DAL.Entities
{
    public class Content_Element_Type_Translation
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int Content_Element_TypeId { get; set; }
        public Content_Element_Type Content_Element_Type { get; set; }
        public string Translation { get; set; }
    }
}
