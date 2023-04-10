namespace Store
{
    public class FavoritesProducts
    {
        public Guid Id { get; set; }
        public List<Product> Products { get; set; }

        public FavoritesProducts()
        {
            Id = Guid.NewGuid();
        }
    }
}
