using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.DAL.IRepositories
{
    public interface IQuestion_Formulation_TypeRepository : IRepository<Question_Formulation_Type>
    {
        public List<Question_Formulation_Type_Translation> GetQuestionFormulationTypeTranslatedBySelectedLanguage(int SelectedLanguageId);
    }
}
