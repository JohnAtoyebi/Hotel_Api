namespace WebApplication1.DTO
{
    public class HotelDTO
    {
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string EmailAddress { get; set; } = String.Empty;
        public string PhoneNumber { get; set; } = String.Empty;
        public string AddressId { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public int Price { get; set; }
        public string ManagerId { get; set; } = String.Empty;
    }
}
