using Hotel.API.Enums;

namespace Hotel.API.Dtos
{
    public class ContactInfoDtoForUpdate
    {
        public InfoType InfoType { get; set; }
        public string InfoContent { get; set; }
    }
}
