namespace E4Progress.DAL.Entities
{
    public class Course_Module
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Sortorder { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
