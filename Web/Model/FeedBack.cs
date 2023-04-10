namespace Store
{
    public class FeedBack
    {
        public Guid Id { get; set; }
        public string Image { get; set; }
        public Product ProductName { get; set; }
        public int Mark { get; set; }
        public string Text { get; set; }

        public FeedBack()
        {
            Id = Guid.NewGuid();
        }
    }
}
