using System.Collections.Generic;

namespace X_Technology_ORTv2.Models
{
    public class OrderDetail
    {
        public OrderDetail()
        {
        }

        public OrderDetail(Product product)
        {
            Quantity = 1;
            UnitPrice = product.Price;
            Product = product;
        }

        public int Id { get; set; }
        
        public int Quantity { get; set; }
        
        public float UnitPrice { get; set; }
        
        public Product Product { get; }
    }
}