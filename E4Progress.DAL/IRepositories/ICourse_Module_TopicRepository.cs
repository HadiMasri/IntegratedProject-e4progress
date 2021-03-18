using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;
using System.Collections.Generic;

namespace E4Progress.DAL.IRepositories
{
    public interface ICourse_Module_TopicRepository : IRepository<Course_Module_Topic>
    {
        IEnumerable<Course_Module_Topic> GetTopicsWithModule();

        void Update(Course_Module_Topic course_Module_Topic);
    }
}
