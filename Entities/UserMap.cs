using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplicationDemo.Entities
{
    public class UserMap
    {
        internal UserMap(EntityTypeBuilder<UserEntity> entityBuilder)
        {
            // Primary Key
            entityBuilder.HasKey(t => t.user_id);

            entityBuilder.ToTable("user", "full-stack-ecommerce");
        }
    }
}