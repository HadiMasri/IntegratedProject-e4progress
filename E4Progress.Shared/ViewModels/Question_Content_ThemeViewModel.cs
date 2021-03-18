using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.Shared.ViewModels
{
    public class Question_Content_ThemeViewModel
    {
        public int Id { get; set; }
        public QuestionViewModel Question { get; set; }
        public int QuestionId { get; set; }
        public Content_Thema_ViewModel Content_Theme { get; set; }
        public int Content_ThemeId { get; set; }
    }
}
