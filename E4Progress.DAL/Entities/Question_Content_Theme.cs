
namespace E4Progress.DAL.Entities
{
    public class Question_Content_Theme
    {
        public int Id { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; }
        public Content_Theme Content_Theme { get; set; }
        public int Content_ThemeId { get; set; }

    }
}
