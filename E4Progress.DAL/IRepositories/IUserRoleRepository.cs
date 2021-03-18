using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;

namespace E4Progress.DAL.IRepositories
{
    public interface IUserRoleRepository : IRepository<User_Role>
    {
        public void EndRole(int roleId, int  userId);
    }
}
