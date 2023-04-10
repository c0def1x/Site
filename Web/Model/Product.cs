using System.Numerics;

namespace Store
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public float TotalPrice { get; set; }
        public int PurchasesCount { get; set; }
        public Category Category { get; set; }
        public double AverageRating { get; set; }
        public List<FeedBack> FeedBacks { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }

        public float PriceWithDiscount()
        {
            return Price - (Price * (Discount / 100));
        }
    }
}