namespace E4Progress.DAL.Entities
{
    public class Difficulty_Level_Translation
    {
        public int Id { get; set; }
        public int Difficulty_LevelId { get; set; }
        public Difficulty_Level  Difficulty_Level { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Translation { get; set; }
    }
}
