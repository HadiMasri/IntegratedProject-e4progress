using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.DAL.IRepositories
{
    public interface IDidactical_Model_LevelRepository : IRepository<Didactical_Model_Level>
    {

        void Update(Didactical_Model_Level didactical_Model_Level);
        public List<Didactical_Model_Level_Translation> GetModelLevelTranslatedBySelectedLanguage(int SelectedLanguageId);


    }
}