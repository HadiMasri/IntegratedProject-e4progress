using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.DAL.IRepositories
{
    public interface IQuestion_Content_ThemaRepository : IRepository<Question_Content_Theme>
    {
        void Update(Question_Content_Theme question_Content_Theme);
        List<Question_Content_Theme> GetQuestionContentThemaByQuestionId(int questionId);

    }
}
