using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.Entities;

namespace WebApplicationDemo.DA
{
    public interface IProductDA
    {
        Task<ProductEntity> LoadProductAsync(long id);

        Task<IEnumerable<ProductEntity>> LoadProductsAsync();

        Task<ProductEntity> AddProductAsync(ProductEntity productEntity);

        Task<ProductEntity> UpdateProductAsync(long id,ProductEntity productEntity);

        Task<string> DeleteProductAsync(long id);

    }
}
