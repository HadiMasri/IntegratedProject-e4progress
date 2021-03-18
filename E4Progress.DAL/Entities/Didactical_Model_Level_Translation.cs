namespace E4Progress.DAL.Entities
{
    public class Didactical_Model_Level_Translation
    {
        public int Id { get; set; }
        public int Didactical_Model_LevelId { get; set; }
        public Didactical_Model_Level  Didactical_Model_Level { get; set; }
        public int LanguageId { get; set; }
        public Language  Language { get; set; }
        public string Translation { get; set; }
    }
}
