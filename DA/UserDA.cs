using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationDemo.DA
{
    public class UserDA : IUserDA
    {
        private readonly Context _context;

        public UserDA(Context context)
        {
            _context = context;
        }

       public async Task<UserEntity> RegisterUserAsync(UserEntity userEntity)
        {
            UserEntity user = new UserEntity{
                    user_name = userEntity.user_name,
                    password = userEntity.password,
                    favorite_qn = userEntity.favorite_qn,
                    answer = userEntity.answer
            };
            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<UserEntity> LoginUserAsync(UserEntity userEntity)
        {
            UserEntity user = await _context.User.Where(x=>x.user_name.Equals(userEntity.user_name) 
            && x.password.Equals(userEntity.password)).FirstOrDefaultAsync();
            
            if(user!=null)
            return user;
            else
            return null;
        }

        public async Task<UserEntity> UpdateUserAsync(UserEntity userEntity)
        {
            UserEntity user = await _context.User.Where(x=>x.user_name.Equals(userEntity.user_name)).FirstOrDefaultAsync();
            
                   user.password=userEntity.password;
                   user.favorite_qn = userEntity.favorite_qn;
                   user.answer = userEntity.answer;
            
             _context.User.Update(user);
              await _context.SaveChangesAsync();
              return user;
        }

        public async Task<string> DeleteUserAsync(UserEntity userEntity)
        {
            UserEntity user = await _context.User.Where(x=>x.user_name.Equals(userEntity.user_name) 
            && x.password.Equals(userEntity.password)).FirstOrDefaultAsync();

           _context.User.Remove(user);
           await _context.SaveChangesAsync();
           return $"Deleted product {user.user_name}";
        }
    }
}