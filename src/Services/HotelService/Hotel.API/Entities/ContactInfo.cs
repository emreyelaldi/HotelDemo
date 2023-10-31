namespace Hotel.API.Entities
{
    public class ContactInfo : BaseEntity
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Hotel Hotel { get; set; }
    }
}
