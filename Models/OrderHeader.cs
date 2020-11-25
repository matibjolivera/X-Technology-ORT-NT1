using System;
using System.Collections.Generic;
using X_Technology_ORTv2.Utils;

namespace X_Technology_ORTv2.Models
{
    public class OrderHeader
    {
        private const int QuantityCharsReference = 8;

        public OrderHeader()
        {
            
        }
        
        public OrderHeader(float totalPaid, string paymentMethod, string shippingMethod, Billing billing, Shipping shipping)
        {
            Reference = StringsUtil.RandomString(QuantityCharsReference);
            TotalPaid = totalPaid;
            PaymentMethod = paymentMethod;
            ShippingMethod = shippingMethod;
            Billing = billing;
            Shipping = shipping;
            Details = new List<OrderDetail>();
        }

        public int Id { get; set; }
        
        public string Reference { get; set; }
        
        public float TotalPaid { get; set; }
        
        public string PaymentMethod { get; set; }
        
        public string ShippingMethod { get; set; }
        
        public Billing Billing { get; set; }
        
        public Shipping Shipping { get; set; }
        
        public List<OrderDetail> Details { get; set; }
    }
}