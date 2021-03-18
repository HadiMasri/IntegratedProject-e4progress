namespace E4Progress.Domain.DTO
{
    public class Course_ModuleDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Sortorder { get; set; }
        public int CourseId { get; set; }
        public CourseDto Course { get; set; }
    }
}
