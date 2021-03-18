using E4Progress.DAL.Entities;
using E4Progress.DAL.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace E4Progress.Service.Controllers
{
    [Route("{culture:culture}/api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ILogger<UserRoleController> _logger;

        public UserRoleController(IUnitOfWork unitOfWork, ILogger<UserRoleController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpPost("AsigneRoleToUser")]
        public IActionResult AsigneRoleToUser(User_Role asigneRole)
        {
            if (asigneRole != null)
            {
                _unitOfWork.UserRole.Add(asigneRole);
                _unitOfWork.Save();
                _logger.LogInformation($" Role {asigneRole.RoleId} assigned to user with id {asigneRole.UserId}");

                return Ok(asigneRole);
            }
            else
            {
                _logger.LogError($"An error occurred while trying to  assigne role {asigneRole.RoleId} to user with id {asigneRole.UserId}");

                return BadRequest(asigneRole);
            }
        }

        /// <summary>
        /// end role for a user
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="userId"></param>
        [HttpDelete("endRole/{roleId}/{userId}")]
        public void EndRole(int roleId, int userId)
        {
            try
            {
                _unitOfWork.UserRole.EndRole(roleId, userId);
                _unitOfWork.Save();
                _logger.LogInformation($"Role deleted from user with id {userId}");
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message}");
                throw new Exception(ex.Message);         
            }
        }
    }
}
