using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E4Progress.DAL.Repositories
{
    public class LanguageRepository : Repository<Language>, ILanguageRepository
    {
        private E4ProgressDBContext _context;
        private IMapper _mapper;

        public LanguageRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Language_Translation> GetLanguageTranslatedBySelectedLanguage(int SelectedLanguageId)
        {
            var languages = _context.Language_Translations.Where(x => x.Translation_LanguageId == SelectedLanguageId).ToList();
            return languages;
        }

        public void Update(Language language)
        {
            throw new NotImplementedException();
        }
    }
}
