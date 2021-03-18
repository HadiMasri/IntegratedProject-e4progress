namespace E4Progress.DAL.Entities
{
    public class Didactical_Model_Level
    {
        public int Id { get; set; }
        public int Didactical_ModelId { get; set; }
        public Didactical_Model Didactical_Model { get; set; }
        public string Name { get; set; }
        public int Sortorder { get; set; }
    }
}
