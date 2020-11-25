using System.Collections.Generic;
using X_Technology_ORTv2.Models;

namespace X_Technology_ORTv2.ViewModels
{
    public class OrderHeaderViewModel
    {
        public string ShippingMethod { get; set; }
        
        public string PaymentMethod { get; set; }
        
        public Billing Billing { get; set; }
        public Shipping Shipping { get; set; }
        public int ProductId { get; set; }
    }
}