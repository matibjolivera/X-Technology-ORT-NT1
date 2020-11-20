using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X_Technology_ORTv2.Models;

namespace X_Technology_ORTv2.Configuration
{
    public class OrderHeaderConfiguration : IEntityTypeConfiguration<OrderHeader>
    {
        public void Configure(EntityTypeBuilder<OrderHeader> builder)
        {
            builder.ToTable("OrdersHeader");
            builder.HasData(
                new OrderHeader
                {
                    Id = 1,
                    Reference = "abc",
                    TotalPaid = 520,
                    PaymentMethod = "Paypal",
                    ShippingMethod = "A domicilio",
                    Billing = Context.get,
                    Shipping = ,
                    Details = new List<OrderDetail>()
                    {
                        new OrderDetail
                        {
                            Id = 1,
                            Quantity = 2,
                            UnitPrice = 160
                        },
                        new OrderDetail
                        {
                            Id = 2,
                            Quantity = 1,
                            UnitPrice = 200
                        }
                    }
                }
            );
        }
    }
}
