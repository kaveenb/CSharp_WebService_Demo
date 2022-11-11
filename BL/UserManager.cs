using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.DA;
using WebApplicationDemo.Entities;

namespace WebApplicationDemo.BL
{
    public class UserManager : IUserManager
    {
         private readonly IUserDA _userDa;

        public UserManager(IUserDA userDA)
        {
           _userDa = userDA;
        }

        public async Task<UserEntity> LoginUserAsync(UserEntity userEntity)
        {
            return await _userDa.LoginUserAsync(userEntity);
        }

        public async Task<UserEntity> RegisterUserAsync(UserEntity userEntity)
        {
             return await _userDa.RegisterUserAsync(userEntity);
        }

        public async Task<UserEntity> SelectUserAsync(String username)
        {
            return await _userDa.SelectUserAsync(username);
        }

        public async Task<string> DeleteUserAsync(UserEntity userEntity)
        {
              return await _userDa.DeleteUserAsync(userEntity);
        }

        public async Task<UserEntity> UpdateUserAsync(UserEntity userEntity)
        {
            return await _userDa.UpdateUserAsync(userEntity);
        }

    }
}