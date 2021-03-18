using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.DAL.IRepositories
{
    public interface IQuestion_Pre_Knowledge_SkillRepository : IRepository<Question_Pre_Knowledge_Skill>
    {

        void Update(Question_Pre_Knowledge_Skill question_Pre_Knowledge_Skill);
        List<Question_Pre_Knowledge_Skill> GetPreKnowledgeSkillByQuestionId(int questionId);

    }
}
