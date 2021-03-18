using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4Progress.DAL.Repositories
{
    public class Question_Pre_Knowledge_SkillRepository : Repository<Question_Pre_Knowledge_Skill>, IQuestion_Pre_Knowledge_SkillRepository
    {
        private readonly E4ProgressDBContext _context;
        private readonly IMapper _mapper;

        public Question_Pre_Knowledge_SkillRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public void Update(Question_Pre_Knowledge_Skill question_Pre_Knowledge_Skill)
        {
            var objFromDb = _context.Question_Pre_Knowledge_Skills.FirstOrDefault(cm => cm.Id == question_Pre_Knowledge_Skill.Id);
            if (objFromDb != null)
            {
                objFromDb.Id = question_Pre_Knowledge_Skill.Id;
                objFromDb.Skill = question_Pre_Knowledge_Skill.Skill;
                objFromDb.Sortorder = objFromDb.Sortorder;
                objFromDb.QuestionId = objFromDb.QuestionId;
            }
        }
        public List<Question_Pre_Knowledge_Skill> GetPreKnowledgeSkillByQuestionId(int questionId)
        {
            List<Question_Pre_Knowledge_Skill> question_Pre_Knowledge = _context.Question_Pre_Knowledge_Skills.Where(x => x.QuestionId == questionId).ToList();
            return question_Pre_Knowledge;
        }
    }
}
