namespace E4Progress.DAL.Entities
{
    public class Course_Module_Topic
    {
        public int Id { get; set; }
        public Course_Module Course_Module { get; set; }
        public int Course_ModuleId { get; set; }
        public string Title { get; set; }
        public int Sortorder { get; set; }
    }
}
