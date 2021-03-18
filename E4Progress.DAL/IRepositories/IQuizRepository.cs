using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;

namespace E4Progress.DAL.IRepositories
{
    public interface IQuizRepository : IRepository<Quiz>
    {
        void Update(Quiz quiz);
    }
}