namespace E4Progress.DAL.Entities
{
    public class ExcerciseFile
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public bool Contains_Currency { get; set; }
        public bool Contains_Date { get; set; }
        public bool Contains_Time { get; set; }
        public bool Contains_Geographical { get; set; }
        public bool Contains_Names_To_Translate { get; set; }
    }
}
