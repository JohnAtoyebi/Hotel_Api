namespace WebApplication1.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string EmailAddress { get; set; } = String.Empty;
        public string PhoneNumber { get; set; } = String.Empty;
        public string AddressId { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public int Price { get; set; }
        public string ManagerId { get; set; } = String.Empty;
        /*public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }*/
    }
}
