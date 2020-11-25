namespace X_Technology_ORTv2.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public string Sku { get; set; }

        public float Price { get; set; }
        
        public string Brand { get; set; }
        
        public string Category { get; set; }
        
        public string ImageUrl { get; set; }
    }
}