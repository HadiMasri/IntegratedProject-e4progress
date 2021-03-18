namespace E4Progress.DAL.Entities
{
    public class QuestionType_Translation
    {
        public int Id { get; set; }
        public int QuestionTypeId  { get; set; }
        public QuestionType  QuestionType { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Translation { get; set; }
    }
}
