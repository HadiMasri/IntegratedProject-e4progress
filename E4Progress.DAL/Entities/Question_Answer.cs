namespace E4Progress.DAL.Entities
{
    public class Question_Answer
    {
        public int Id { get; set; }
        public int QuestionId{ get; set; }
        public string Answer { get; set; }
    }
}
