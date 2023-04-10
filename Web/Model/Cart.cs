namespace Store
{
    public class Cart
    {
        public Guid Id { get; set; }
        public List<Product> Products { get; set; }

        public Cart()
        {
            Id = Guid.NewGuid();
        }
    }
}
