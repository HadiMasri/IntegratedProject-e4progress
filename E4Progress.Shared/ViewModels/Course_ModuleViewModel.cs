namespace E4Progress.Shared.ViewModels
{
    public class Course_ModuleViewModel 
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public CourseViewModel Course { get; set; }
        public string Title { get; set; }
        public int Sortorder { get; set; }
    }
}
