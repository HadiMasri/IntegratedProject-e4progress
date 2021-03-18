using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;
using System.Collections.Generic;

namespace E4Progress.DAL.IRepositories
{
    public interface ICourse_Module_Topic_ElementRepository : IRepository<Course_Module_Topic_Element>
    {
        IEnumerable<Course_Module_Topic_Element> GetElementsWithTopic();

        void Update(Course_Module_Topic_Element course_Module_Topic_Element);
    }
}
