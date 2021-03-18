namespace E4Progress.DAL.Entities
{
    public class Didactical_Model_Translation
    {
        public int Id { get; set; }
        public int Didactical_ModelId { get; set; }
        public Didactical_Model  Didactical_Model { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Translation { get; set; }
    }
}
