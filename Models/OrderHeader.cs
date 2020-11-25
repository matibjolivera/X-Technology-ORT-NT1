using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        
        [Required]
        public string Reference { get; set; }
        
        [Required]
        public float TotalPaid { get; set; }
        
        [Required]
        public string PaymentMethod { get; set; }
        
        [Required]
        public string ShippingMethod { get; set; }
        
        [Required]
        public Billing Billing { get; set; }
        
        [Required]
        public Shipping Shipping { get; set; }
        
        public List<OrderDetail> Details { get; set; }
    }
}