using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X_Technology_ORTv2.Models;

namespace X_Technology_ORTv2.Configuration
{
    public class BillingConfiguration : IEntityTypeConfiguration<Billing>
    {
        public void Configure(EntityTypeBuilder<Billing> builder)
        {
            builder.ToTable("Billings");
            builder.HasData(
                new Billing
                {
                    Id = 1,
                    Firstname = "Pepe",
                    Lastname = "Rodriguez",
                    Document = "12345678",
                    Email = "pepito@yahoo.com.ar"
                },
                new Billing
                {
                    Id = 2,
                    Firstname = "Salomon",
                    Lastname = "R",
                    Document = "12345679",
                    Email = "salo@gmail.com.ar"
                }
            );
        }
    }
}
