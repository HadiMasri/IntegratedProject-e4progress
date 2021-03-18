using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;
using System.Collections.Generic;

namespace E4Progress.DAL.IRepositories
{
    public interface ICourse_ModuleRepository : IRepository<Course_Module>
    {
        IEnumerable<Course_Module> GetModulesWithCourse();

        void Update(Course_Module course_Module);
    }
}
