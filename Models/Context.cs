using Microsoft.EntityFrameworkCore;
using X_Technology_ORTv2.Configuration;

namespace X_Technology_ORTv2.Models
{
    public partial class Context : DbContext
    {
        public virtual DbSet<Billing> Billings { get; set; }
        public virtual DbSet<OrderDetail> OrdersDetails { get; set; }
        public virtual DbSet<OrderHeader> OrdersHeader { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shipping> Shippings { get; set; }

        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}