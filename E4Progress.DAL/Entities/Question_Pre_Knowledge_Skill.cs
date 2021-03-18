namespace E4Progress.DAL.Entities
{
    public class Question_Pre_Knowledge_Skill
    {
        public int Id { get; set; }
        public string Skill { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int Sortorder { get; set; }
    }
}
