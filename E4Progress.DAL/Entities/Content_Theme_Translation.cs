namespace E4Progress.DAL.Entities
{
    public class Content_Theme_Translation
    {
        public Content_Theme Content_Theme { get; set; }
        public int Content_Theme_Id { get; set; }
        public Language Language { get; set; }
        public int Language_Id { get; set; }
        public string Translation { get; set; }   
    }
}
