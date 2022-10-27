using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationDemo.DA
{
    public sealed class ProductDA : IProductDA
    {
        private readonly Context _context;

        public ProductDA(Context context)
        {
            _context = context;
        }

        public async Task<ProductEntity> LoadProductAsync(long iD)
        {
            return await _context.Product.Where(x=> x.id == iD).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ProductEntity>> LoadProductsAsync()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<ProductEntity> AddProductAsync(ProductEntity productEntity)
        {
            ProductEntity product = new ProductEntity{
                    id = productEntity.id,
                    name =productEntity.name,
                    sku = productEntity.sku,
                    description = productEntity.description,
                    date_created = productEntity.date_created,
                    last_updated = productEntity.last_updated,
                    units_in_stock = productEntity.units_in_stock,
                    unit_price = productEntity.unit_price,
                    active = productEntity.active,
                    image_url = productEntity.image_url,
                    category_id = productEntity.category_id
            };
            await _context.Product.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<ProductEntity> UpdateProductAsync(long id,ProductEntity productEntity)
        {
            ProductEntity product = await _context.Product.FindAsync(id);
            
                    product.id = productEntity.id;
                    product.name =productEntity.name;
                    product.sku = productEntity.sku;
                    product.description = productEntity.description;
                    product.date_created = productEntity.date_created;
                    product.last_updated = productEntity.last_updated;
                    product.units_in_stock = productEntity.units_in_stock;
                    product.unit_price = productEntity.unit_price;
                    product.active = productEntity.active;
                    product.image_url = productEntity.image_url;
                    product.category_id = productEntity.category_id;
            
             _context.Product.Update(product);
              await _context.SaveChangesAsync();
              return product;
        }

        public async Task<string> DeleteProductAsync(long iD)
        {
            ProductEntity product = await _context.Product.Where(x=> x.id == iD).FirstOrDefaultAsync();
           _context.Product.Remove(product);
           await _context.SaveChangesAsync();
           return $"Deleted product {product.name}";
        }
       
    }
}
