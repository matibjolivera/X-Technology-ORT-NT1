using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X_Technology_ORTv2.Models;

namespace X_Technology_ORTv2.Configuration
{
    public class ShippingConfiguration : IEntityTypeConfiguration<Shipping>
    {
        public void Configure(EntityTypeBuilder<Shipping> builder)
        {
            builder.ToTable("Shippings");
            builder.HasData(
                new Shipping
                {
                    Id = 1,
                    Firstname = "Jorge",
                    Lastname = "Serrano",
                    Address = "yatay",
                    ZipCode = "1000",
                    ExtraInformation = null,
                    City = "Buenos Aires"
                },
                new Shipping
                {
                    Id = 2,
                    Firstname = "Matias",
                    Lastname = "Olivera",
                    Address = "yatay",
                    ZipCode = "1000",
                    ExtraInformation = null,
                    City = "Buenos Aires"
                },
                new Shipping
                {
                    Id = 3,
                    Firstname = "Ariel",
                    Lastname = "Bonfil",
                    Address = "yatay",
                    ZipCode = "1000",
                    ExtraInformation = null,
                    City = "Buenos Aires"
                },
                new Shipping
                {
                    Id = 4,
                    Firstname = "Nicolas",
                    Lastname = "Altman",
                    Address = "yatay",
                    ZipCode = "1000",
                    ExtraInformation = null,
                    City = "Buenos Aires"
                }
            );
        }
    }
}
