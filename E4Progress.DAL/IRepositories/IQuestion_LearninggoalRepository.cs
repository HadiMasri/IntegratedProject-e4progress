using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.DAL.IRepositories
{
    public interface IQuestion_LearninggoalRepository : IRepository<Question_Learninggoal>
    {

        void Update(Question_Learninggoal question_Learninggoal);
        List<Question_Learninggoal> GetLearningGoalByQuestionId(int questionId);


    }
}
