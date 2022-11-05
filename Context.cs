using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.Entities;

namespace WebApplicationDemo
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProductEntity> Product { get; set; }

        public DbSet<UserEntity> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ProductMap(modelBuilder.Entity<ProductEntity>());
            new UserMap(modelBuilder.Entity<UserEntity>());
        }
    }
}
