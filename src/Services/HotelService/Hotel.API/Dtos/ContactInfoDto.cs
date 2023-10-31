using Hotel.API.Enums;

namespace Hotel.API.Dtos
{
    public class ContactInfoDto
    {
        public InfoType InfoType { get; set; }
        public string InfoContent { get; set; }
    }
}
