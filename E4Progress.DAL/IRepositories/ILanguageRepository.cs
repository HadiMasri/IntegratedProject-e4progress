using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;
using System.Collections.Generic;

namespace E4Progress.DAL.IRepositories
{
    public interface ILanguageRepository : IRepository<Language>
    {
        void Update(Language language);
        public List<Language_Translation> GetLanguageTranslatedBySelectedLanguage(int SelectedLanguageId);
    }
}
