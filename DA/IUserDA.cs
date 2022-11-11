using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.Entities;

namespace WebApplicationDemo.DA
{
    public interface IUserDA
    {
        Task<UserEntity> LoginUserAsync(UserEntity userEntity);
        Task<UserEntity> RegisterUserAsync(UserEntity userEntity);
        Task<UserEntity> SelectUserAsync(String username);
        Task<UserEntity> UpdateUserAsync(UserEntity userEntity);
        Task<string> DeleteUserAsync(UserEntity userEntity);
    }
}