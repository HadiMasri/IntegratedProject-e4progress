using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;

namespace E4Progress.DAL.IRepositories
{
    public interface IOffice_ApplicationRepository : IRepository<Office_Application>
    {
        void Update(Office_Application office_Application);
    }
}
