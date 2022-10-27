using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.DA;
using WebApplicationDemo.Entities;

namespace WebApplicationDemo.BL
{
    public class ProductManager : IProductManager
    {
        private readonly IProductDA _productDa;

        public ProductManager(IProductDA productDa)
        {
           _productDa = productDa;
        }
        public async Task<ProductEntity> LoadProductAsync(long id)
        {
            return await _productDa.LoadProductAsync(id);
        }

        public async Task<IEnumerable<ProductEntity>> LoadProductsAsync()
        {
            return await _productDa.LoadProductsAsync();
        }

        public async Task<ProductEntity> UpdateProductsAsync(long id, ProductEntity productEntity)
        {
             await _productDa.UpdateProductAsync(id, productEntity);
              return  productEntity;
        }

        public async Task<string> DeleteProductsAsync(long id)
        {
              return await _productDa.DeleteProductAsync(id);
             
        }

        public async Task<ProductEntity> AddProductsAsync(ProductEntity productEntity)
        {
              await _productDa.AddProductAsync(productEntity);
              return productEntity;
        }
     
    
    }
}
