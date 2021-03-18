using E4Progress.DAL.Entities;
using E4Progress.Shared.ViewModels;
using E4Progress.Domain.DTO;
using System.Collections.Generic;

namespace E4Progress.DAL.IRepository
{
   public interface IUserRepository : IRepository<User>
    {
        public AuthResultViewModel Registration(UserDto userDTO);
        public AuthResultViewModel Login(UserLoginDto userLoginDto);
        public AuthResultViewModel ChangePassword(ChangePasswordViewModel chnagePassword);
        public List<User_Role> GetUserRolesByUserId(int userId);
        public List<Role> GetRoles();
        public  void ChangeLanguage(UserViewModelFull  userViewModelFull);
        public User GetUserByEmail(string email);
  
    }
}
