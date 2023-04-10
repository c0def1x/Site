namespace Store
{
    public class ClientProfile
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public ClientOrders Orders { get; set; }
        public Cart Cart { get; set; }
        public FavoritesProducts FavoritesProducts { get; set; }

        public ClientProfile()
        {
            Id = Guid.NewGuid();
        }
    }
}
