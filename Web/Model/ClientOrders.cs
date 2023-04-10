namespace Store
{
    public class ClientOrders
    {
        public Guid Id { get; set; }
        public List<Order> Orders { get; set; }

        public ClientOrders()
        {
            Id = Guid.NewGuid();
        }
    }
}
