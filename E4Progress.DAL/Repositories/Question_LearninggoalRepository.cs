using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4Progress.DAL.Repositories
{
    public class Question_LearninggoalRepository : Repository<Question_Learninggoal>, IQuestion_LearninggoalRepository
    {
        private readonly E4ProgressDBContext _context;
        private readonly IMapper _mapper;

        public Question_LearninggoalRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public void Update(Question_Learninggoal question_Learninggoal)
        {
            var objFromDb = _context.Question_Learninggoals.FirstOrDefault(cm => cm.Id == question_Learninggoal.Id);
            if (objFromDb != null)
            {
                objFromDb.Id = question_Learninggoal.Id;
                objFromDb.Sortorder = question_Learninggoal.Sortorder;
                objFromDb.Notes = question_Learninggoal.Notes;
                objFromDb.QuestionId = question_Learninggoal.QuestionId;
                objFromDb.Learninggoal = question_Learninggoal.Learninggoal;
                objFromDb.Is_Measurable = question_Learninggoal.Is_Measurable;
                objFromDb.Didactical_Model_LevelId = question_Learninggoal.Didactical_Model_LevelId;
            }
        }
        public List<Question_Learninggoal> GetLearningGoalByQuestionId(int questionId)
        {
            List<Question_Learninggoal> question_Pre_Knowledge = _context.Question_Learninggoals.Where(x => x.QuestionId == questionId).ToList();
            return question_Pre_Knowledge;
        }
    }
}
