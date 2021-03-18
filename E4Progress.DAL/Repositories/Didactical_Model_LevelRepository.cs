using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4Progress.DAL.Repositories
{
    public class Didactical_Model_LevelRepository : Repository<Didactical_Model_Level>, IDidactical_Model_LevelRepository
    {
        private readonly E4ProgressDBContext _context;
        private readonly IMapper _mapper;

        public Didactical_Model_LevelRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Didactical_Model_Level_Translation> GetModelLevelTranslatedBySelectedLanguage(int SelectedLanguageId)
        {
            var modelLevel_Translations = _context.Didactical_Model_Level_Translations.Where(x => x.LanguageId == SelectedLanguageId).ToList();
            return modelLevel_Translations;
        }

        public void Update(Didactical_Model_Level didactical_Model_Level)
        {
            //var objFromDb = _context.Content_Themes.FirstOrDefault(cm => cm.Id == content_Theme.Id);
            //if (objFromDb != null)
            //{
            //    objFromDb.Id = content_Theme.Id;
            //    objFromDb.Name = content_Theme.Name;
            //    objFromDb.Content_Theme_Translations = objFromDb.Content_Theme_Translations;
            //}
        }
    }
}
