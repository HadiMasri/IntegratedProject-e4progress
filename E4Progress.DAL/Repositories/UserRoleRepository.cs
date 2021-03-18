using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;

namespace E4Progress.DAL.Repositories
{
   public class UserRoleRepository : Repository<User_Role>, IUserRoleRepository
    {
        private E4ProgressDBContext _context;
        private IMapper _mapper;
  
        public UserRoleRepository(E4ProgressDBContext context, IMapper mapper ) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void EndRole(int roleId, int userId)
        {
            try
            {
                var userRole = _context.User_Roles.Include(x => x.Role).Include(x => x.User).FirstOrDefaultAsync(x => x.RoleId == roleId && x.UserId == userId).Result;
                _context.User_Roles.Remove(userRole);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
