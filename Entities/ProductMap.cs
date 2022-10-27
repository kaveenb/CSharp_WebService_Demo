using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Entities
{
    internal class ProductMap
    {
        internal ProductMap(EntityTypeBuilder<ProductEntity> entityBuilder)
        {
            // Primary Key
            entityBuilder.HasKey(t => t.id);

            entityBuilder.ToTable("product", "full-stack-ecommerce");
        }
    }
}
