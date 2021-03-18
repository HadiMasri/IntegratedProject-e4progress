namespace E4Progress.DAL.Entities
{
    public class Question_Learninggoal
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int Didactical_Model_LevelId { get; set; }
        public Didactical_Model_Level Didactical_Model_Level { get; set; }
        public string Learninggoal { get; set; }
        public bool Is_Measurable { get; set; }
        public string Notes { get; set; }
        public int Sortorder { get; set; }
    }
}
