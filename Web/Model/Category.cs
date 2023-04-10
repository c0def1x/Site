namespace Store
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public List<Product> Products { get; set; }

        public Category()
        {
            Id = Guid.NewGuid();
        }
    }
}
