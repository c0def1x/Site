namespace Store
{
    public class Order
    {
        public Guid Id { get; set; }
        public List<Product> Products { get; set; }
        public bool PaymentMethod { get; set; }
        public float TotalPrice { get; set; }
        public ClientProfile Address { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DeliveryDateAndTime { get; set; }
        public bool Status { get; set; }

        public Order()
        {
            Id = Guid.NewGuid();
        }
    }
}