using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;

namespace E4Progress.DAL.IRepositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        void Update(Course course);
    }
}
