namespace E4Progress.DAL.Entities
{
    public class Quiz_Question_Answer
    {
        public int Quiz_Id { get; set; }
        public int Question_Id { get; set; }
        public int Question_Answer_Id { get; set; }
        public decimal Fraction { get; set; }
    }
}
