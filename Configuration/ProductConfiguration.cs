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
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Title = "Auriculares",
                    Price = 200,
                    Brand = "Samsung",
                    Sku = "1",
                    Category = "Sonido",
                    ImageUrl = "https://dummyimage.com/600x400/000/fff"
                },
                new Product
                {
                    Id = 2,
                    Title = "Parlante",
                    Price = 160,
                    Brand = "JBL",
                    Sku = "3",
                    Category = "Sonido",
                    ImageUrl = "https://d34zlyc2cp9zm7.cloudfront.net/products/7840b4935124524a1351becd203fc8ff992b1785a1ffaf8287a26aadb90953fc.jpg_1000"
                },
                new Product
                {
                    Id = 3,
                    Title = "Television",
                    Price = 350,
                    Brand = "LG",
                    Sku = "3",
                    Category = "Entretenimiento",
                    ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_2X_930556-MLA41195666242_032020-V.webp"
                },
                new Product
                {
                    Id = 4,
                    Title = "Television",
                    Price = 400,
                    Brand = "Samsung",
                    Sku = "1",
                    Category = "Entretenimiento",
                    ImageUrl = "https://i1.wp.com/clipset.com/wp-content/uploads/2016/05/samsung-smart-tv.jpg?fit=916%2C600&ssl=1"
                }
            );
        }
    }
}