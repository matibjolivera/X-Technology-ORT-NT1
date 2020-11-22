using System.Collections.Generic;

namespace X_Technology_ORTv2.Models
{
    public class OrderDetail
    {
        public OrderDetail()
        {
        }

        public int Id { get; set; }
        
        public int Quantity { get; set; }
        
        public float UnitPrice { get; set; }
        
        public Product Product { get; set; }
    }
}