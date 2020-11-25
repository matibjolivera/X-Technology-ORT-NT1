using System.Collections.Generic;
using X_Technology_ORTv2.Models;

namespace X_Technology_ORTv2.ViewModels
{
    public class OrderHeaderViewModel
    {
        public OrderHeader OrderHeader { get; set; }
        public Billing Billing { get; set; }
        public Shipping Shipping { get; set; }
        public List<Product> Products { get; set; }
    }
}