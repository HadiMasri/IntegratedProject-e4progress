using System;
using E4Progress.DAL.UnitOfWork;
using E4Progress.Shared.ViewModels;
using E4Progress.Domain.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Localization;
using E4Progress.DAL.Entities;
using Microsoft.Extensions.Logging;

namespace E4Progress.Service.Controllers
{
    [Route("{culture:culture}/api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IStringLocalizer<UserController> _localizer;
        private ILogger<UserController> _logger;

        public UserController(IUnitOfWork unitOfWork, IStringLocalizer<UserController> localizer, ILogger<UserController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpPost("Register")]
        //[Authorize(Roles = "Admin")]
        public IActionResult Register([FromBody] UserDto userDto)
        {
            var authResult = _unitOfWork.User.Registration(userDto);
            if (authResult.IsSuccess)
            {
                _logger.LogInformation("User Registered successfully!");

                return Ok(authResult);
            }
            else
            {
                _logger.LogError("An error occurred while trying to register a user");

                return BadRequest(authResult);
            }
        }

        [HttpPost("Login")]
        public IActionResult Login(UserLoginDto userLogin)
        {
            var authResult = _unitOfWork.User.Login(userLogin);
            if (authResult.IsSuccess)
            {
                _logger.LogInformation(_localizer[authResult.Message]);
                return Ok(authResult);
            }
            else
            {
                _logger.LogError(_localizer[authResult.Message]);
                return BadRequest(authResult);
            }
        }

        [HttpPost("ChangePassword")]
        public IActionResult ChangePassword(ChangePasswordViewModel chnagePassword)
        {
            var authResult = _unitOfWork.User.ChangePassword(chnagePassword);
            if (authResult.IsSuccess)
            {
                //_logger.LogInformation("Your password has been changed successfully !");

                _logger.LogInformation(_localizer[authResult.Message]);
                return Ok(authResult);
            }
            else
            {
                // _logger.LogError("An error occurred while trying to change your password");
                _logger.LogError(_localizer[authResult.Message]);
                return BadRequest(_localizer[authResult.Message].Value);
            }
        }

        [HttpGet("Role")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetRole()
        {
            var authResult = _unitOfWork.User.GetRoles();
            if (authResult.Count > 0)
            {
                _logger.LogInformation("Get all roles succeded ");
                return Ok(authResult);
            }
            else
            {
                _logger.LogError("An error occurred while trying to get all roles ");
                return BadRequest(authResult);
            }
        }

        [HttpGet("Users")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetUsers()
        {
            var authResult = _unitOfWork.User.GetAll();
            if (authResult.Count > 0)
            {
                _logger.LogInformation("Get all user succeded !");
                return Ok(authResult);
            }
            else
            {
                _logger.LogError("An error occurred while trying to all users ");
                return BadRequest(authResult);
            }
        }

        [HttpGet("UserRoles")]
        //[Authorize(Roles = "Admin")]
        public IActionResult GetUserRoles(int userId)
        {
            var authResult = _unitOfWork.User.GetUserRolesByUserId(userId);
            if (authResult.Count > 0)
            {
                _logger.LogInformation($"Get all roles for a single user succeded! with id{userId}");
                return Ok(authResult);
            }
            else
            {

                _logger.LogError($"An error occurred while trying to  get roles for user with id {userId} ");
                return BadRequest(authResult);
            }
        }

        [HttpPost("ChangeLanguage")]
        public   void ChangeLanguage(int languageId , UserViewModelFull  userViewModelFull)
        {
            try
            {
                _logger.LogInformation($"Language has been changed for user {userViewModelFull.Firstname} {userViewModelFull.Lastname} ");
                _unitOfWork.User.ChangeLanguage(userViewModelFull);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred while trying to  change password for user with id  {userViewModelFull.Firstname} {userViewModelFull.Lastname} ");
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("UserByEmail/{email}")]
        public User GetUserByEmail(string email)
        {
            try
            {
                _logger.LogInformation($"Get user with E-mail {email} succeded");
                return _unitOfWork.User.GetUserByEmail(email);
                
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred while trying to  get  user with E-mail  {email}  ");
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                if (id == 0) return BadRequest();

                _unitOfWork.User.Remove(id);
                _unitOfWork.Save();
                _logger.LogInformation($" User with id {id} deleted Successfully ! ");
                return Ok("User deleted successfully !");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
