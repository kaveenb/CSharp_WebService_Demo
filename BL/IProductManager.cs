using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.Entities;

namespace WebApplicationDemo.BL
{
    public interface IProductManager
    {
        Task<ProductEntity> LoadProductAsync(long id);

        Task<IEnumerable<ProductEntity>> LoadProductsAsync();

        Task<ProductEntity> UpdateProductsAsync(long id, ProductEntity productEntity);

        Task<String> DeleteProductsAsync(long id);

        Task<ProductEntity> AddProductsAsync(ProductEntity productEntity);
    
    }
}
