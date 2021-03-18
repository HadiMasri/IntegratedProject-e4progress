namespace E4Progress.DAL.Entities
{
    public class Question_Formulation_Type_Translation
    {
        public int Id { get; set; }
        public int Question_Formulation_TypeId { get; set; }
        public Question_Formulation_Type  Question_Formulation_Type { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Translation { get; set; }
    }
}
