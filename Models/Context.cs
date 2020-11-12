using Microsoft.EntityFrameworkCore;

namespace X_Technology_ORTv2.Models
{
    public class Context : DbContext
    {
        public virtual DbSet<Billing> Billings { get; set; }
        public virtual DbSet<OrderDetail> OrdersDetails { get; set; }
        public virtual DbSet<OrderHeader> OrdersHeader { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shipping> Shippings { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=localhost; Initial Catalog=XTechnologyORT; user id=SA; pwd=XXX"
                );
            }
        }
    }
}