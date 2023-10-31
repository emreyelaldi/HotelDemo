using Hotel.API.Enums;

namespace Hotel.API.Dtos
{
    public class ContactInfoDtoForInsert
    {
        public Guid HotelUUID { get; set; }
        public InfoType InfoType { get; set; }
        public string InfoContent { get; set; }
    }
}
