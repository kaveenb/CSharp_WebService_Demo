using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationDemo.BL;
using WebApplicationDemo.Entities;

namespace WebApplicationDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserManager _userManager;

        public UserController(ILogger<UserController> logger, IUserManager userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        [HttpPost]
        [Route("login")]
        public  Task<UserEntity> LoginUserAsync(UserEntity userEntity)
        {
              return  _userManager.LoginUserAsync(userEntity);
        }

        [HttpPost]
        [Route("register")]
        public  Task<UserEntity> RegisterUserAsync(UserEntity userEntity)
        {
              return  _userManager.RegisterUserAsync(userEntity);
        }

        [HttpDelete]
        public Task<String>  DeleteUserAsync(UserEntity userEntity)
        {
            return  _userManager.DeleteUserAsync(userEntity);
        }

        [HttpPut]
        public  Task<UserEntity> UpdateUserAsync(UserEntity userEntity)
        {
              return _userManager.UpdateUserAsync(userEntity);;
        }
    }
}