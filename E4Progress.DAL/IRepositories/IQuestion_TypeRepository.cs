using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.DAL.IRepositories
{
    public interface IQuestion_TypeRepository : IRepository<QuestionType>
    {
        public List<QuestionType_Translation> GetQuestionTypeTranslatedBySelectedLanguage(int SelectedLanguageId);
    }
}
