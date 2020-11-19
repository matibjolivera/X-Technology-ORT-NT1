using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X_Technology_ORTv2.Models;

namespace X_Technology_ORTv2.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            //builder.HasData(
                /*
                new Product
                {
                    Id = 1,
                    Title = "Product_Test 1",
                    Price = 200
                },
                new Product
                {
                    Id = 2,
                    Title = "Product_Test 2",
                    Price = 160
                },
                new Product
                {
                    Id = 3,
                    Title = "Product_Test 3",
                    Price = 350
                }
                */
            //);
        }
    }
}