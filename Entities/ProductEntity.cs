using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Entities
{
    public class ProductEntity
    {
        public long id { get; set; }

        public string sku { get; set; }

        public string name { get; set; }
       

        public string image_url { get; set; }
        public string description { get; set; }
       
        public decimal unit_price { get; set; }

        
        public bool active { get; set; }
        public DateTime date_created { get; set; }
       public int units_in_stock { get; set; }
        public DateTime? last_updated { get; set; }
       public long category_id { get; set; }
    
    }
}
