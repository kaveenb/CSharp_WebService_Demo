using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.BL;
using WebApplicationDemo.Entities;

namespace WebApplicationDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductManager _productManager;

        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        [HttpGet]
        [Route("{id}")]
        public Task<ProductEntity> GetProduct(long id)
        {
            return  _productManager.LoadProductAsync(id);
        }

        [HttpGet]
        public  Task<IEnumerable<ProductEntity>> GetProducts()
        {
            return  _productManager.LoadProductsAsync();
        }

        [HttpPost]
        public  Task<ProductEntity> AddProduct(ProductEntity productEntity)
        {
              return  _productManager.AddProductsAsync(productEntity);;
        }

        [HttpDelete]
        [Route("{id}")]
        public Task<String>  DeleteProduct(long id)
        {
            return  _productManager.DeleteProductsAsync(id);
        }

        [HttpPut]
        public  Task<ProductEntity> UpdateProduct(long id,ProductEntity productEntity)
        {
              return _productManager.UpdateProductsAsync(id,productEntity);;
        }
    }
}
