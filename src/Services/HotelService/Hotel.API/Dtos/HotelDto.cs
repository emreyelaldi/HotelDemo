using Hotel.API.Entities;

namespace Hotel.API.Dtos
{
    public class HotelDto
    {
        public string AuthorizedFirstName { get; set; }
        public string AuthorizedLastName { get; set; }
        public string CompanyTitle { get; set; }
        public List<ContactInfo> ContactInfos { get; set; } = new();
    }
}
