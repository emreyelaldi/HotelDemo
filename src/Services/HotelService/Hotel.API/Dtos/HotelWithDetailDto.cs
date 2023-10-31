using Hotel.API.Entities;

namespace Hotel.API.Dtos
{
    public class HotelWithDetailDto : HotelDto
    {
        public List<ContactInfo> ContactInfos { get; set; }
    }
}
