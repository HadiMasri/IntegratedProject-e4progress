using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;
using E4Progress.Shared.ViewModels;
using E4Progress.Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace E4Progress.DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private E4ProgressDBContext _context;
        private IMapper _mapper;
        private IConfiguration _configuration;

        public UserRepository(E4ProgressDBContext context, IMapper mapper, IConfiguration configuration) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        public AuthResultViewModel Registration(UserDto userDTO)
        {
            try
            {
                if (_context.Users.Any(x => x.Email.Equals(userDTO.Email)))
                {
                    return new AuthResultViewModel
                    {
                        IsSuccess = false,
                        Message = "Duplicate in Email"
                    };

                }

                var currentUser = _mapper.Map<User>(userDTO);
                byte[] hash, salt;
                GenerateHash(userDTO.Password, out hash, out salt);

                currentUser.PasswordHash = hash;
                currentUser.PasswordSalt = salt;
                currentUser.LanguageId = 1;

                _context.Users.Add(currentUser);
                _context.SaveChanges();

                var userRole = new User_Role
                {
                    UserId = currentUser.Id,
                    RoleId = userDTO.RoleId
                };

                _context.User_Roles.Add(userRole);
                _context.SaveChanges();

                {
                    return new AuthResultViewModel
                    {
                        IsSuccess = true,
                        Message = "User Registerd successfully ! "
                    };
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //Generate Hash Password with salt
        public void GenerateHash(string Password, out Byte[] PassworHash, out Byte[] PasswordSalt)
        {
            using (var hash = new System.Security.Cryptography.HMACSHA512())
            {
                PassworHash = hash.ComputeHash(Encoding.UTF8.GetBytes(Password));
                PasswordSalt = hash.Key;
            }
        }

        public AuthResultViewModel Login(UserLoginDto userLoginDto)
        {
            try
            {
                var currentUser = _context.Users.Include(x => x.language).Where(x => x.Email.Equals(userLoginDto.Email)).SingleOrDefault();

                if (currentUser == null)
                {
                    return new AuthResultViewModel
                    {
                        IsSuccess = false,
                        Message = "Invalid Email"
                    };
                }

                if (!validateHash(userLoginDto.Password, currentUser.PasswordHash, currentUser.PasswordSalt))
                {
                    return new AuthResultViewModel
                    {
                        IsSuccess = false,
                        Message = "Invalid Password!"
                    };
                }

                //Get Role By UserId
                List<User_Role> userRole = GetUserRolesByUserId(currentUser.Id);
                string roles = getRoleAsString(userRole);

                //Generate JWT Token  
                var Claims = new[]
                    {
                    new Claim("FirstName",currentUser.Firstname),
                    new Claim("LastName",currentUser.Lastname),
                    new Claim(JwtRegisteredClaimNames.Email,currentUser.Email),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                    new Claim("UserId", currentUser.Id.ToString()),
                    new Claim("Language", currentUser.language.Code.ToLower()),
                    new Claim("LanguageId", currentUser.language.Id.ToString()),
                    new Claim(ClaimTypes.Role,roles.Split(',')[0]),
                    new Claim(ClaimTypes.Role,roles.Split(',')[1])
            };

                var keyBuffer = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWTSecret"]));
                var desc = new SecurityTokenDescriptor
                {
                    Expires = DateTime.Now.AddHours(2),
                    SigningCredentials = new SigningCredentials(keyBuffer, SecurityAlgorithms.HmacSha256),
                    Subject = new System.Security.Claims.ClaimsIdentity(Claims),

                };

                var token = new JwtSecurityToken(
                        claims: Claims,
                        expires: DateTime.Now.AddHours(2),
                        signingCredentials: new SigningCredentials(keyBuffer, SecurityAlgorithms.HmacSha256)
                    );

                string TokenAsString = new JwtSecurityTokenHandler().WriteToken(token);
                return new AuthResultViewModel
                {
                    IsSuccess = true,
                    Token = TokenAsString,
                    ExpireDate = token.ValidTo,
                    Message = "Login Succeded!"
                };
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private bool validateHash(string Password, byte[] PasswordHash, byte[] PasswordSalt)
        {
            using (var hash = new System.Security.Cryptography.HMACSHA512(PasswordSalt))
            {
                var newHash = hash.ComputeHash(Encoding.UTF8.GetBytes(Password));
                for (int i = 0; i < newHash.Length; i++)
                {
                    if (newHash[i] != PasswordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public AuthResultViewModel ChangePassword(ChangePasswordViewModel chnagePassword)
        {
            try
            {
                var currentUser = _context.Users.Where(x => x.Email.Equals(chnagePassword.Email)).SingleOrDefault();
                var newPasswordHash = new byte[] { };
                var ConfirmPasswordHash = new byte[] { };

                if (currentUser == null)
                {
                    return new AuthResultViewModel
                    {
                        IsSuccess = false,
                        Message = "Invalid Email"
                    };
                }

                if (!validateHash(chnagePassword.Password, currentUser.PasswordHash, currentUser.PasswordSalt))
                {
                    return new AuthResultViewModel
                    {
                        IsSuccess = false,
                        Message = "Invalid Password!"
                    };
                }

                byte[] NewPasswordhash, NewPasswordsalt;
                GenerateHash(chnagePassword.NewPassword, out NewPasswordhash, out NewPasswordsalt);

                byte[] ConfirmPasswordhash, ConfirmPasswordsalt;
                GenerateHash(chnagePassword.NewPassword, out ConfirmPasswordhash, out ConfirmPasswordsalt);

                if (validateHash(chnagePassword.NewPassword, NewPasswordhash, NewPasswordsalt) && validateHash(chnagePassword.ConfirmPassword, ConfirmPasswordhash, ConfirmPasswordsalt) == false)
                {
                    return new AuthResultViewModel
                    {
                        IsSuccess = false,
                        Message = "New Password and Confirm password does not match"
                    };
                }

                currentUser.PasswordHash = NewPasswordhash;
                currentUser.PasswordSalt = NewPasswordsalt;
                _context.Users.Update(currentUser);
                _context.SaveChanges();
                return new AuthResultViewModel
                {
                    IsSuccess = true,
                    Message = "Password has been changed ! "
                };
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<User_Role> GetUserRolesByUserId(int userId)
        {
            try
            {
                var roles = _context.User_Roles.Include(x => x.Role).Where(x => x.UserId == userId).ToList();
                return roles;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private string getRoleAsString(List<User_Role> UserRole)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in UserRole)
            {
                builder.Append(item.Role.Display_Label);
                builder.Append(',');
            }

            string result = builder.ToString();
            return result;
        }

        public List<Role> GetRoles()
        {
            var roles = _context.Roles.ToList();

            return roles;
        }

        // Change Language 
        public  void ChangeLanguage(UserViewModelFull userViewModelFull)
        {
            try
            {
                var currentUser = _context.Users.Where(x => x.Email.Equals(userViewModelFull.Email)).SingleOrDefault();
                currentUser.LanguageId = userViewModelFull.LanguageId;

                _context.Users.Update(currentUser);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public User GetUserByEmail(string email)
        {
            try
            {
                var result = _context.Users.Where(x => x.Email == email).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

  
    }
}
