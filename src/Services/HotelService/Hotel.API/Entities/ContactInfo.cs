﻿using Hotel.API.Enums;

namespace Hotel.API.Entities
{
    public class ContactInfo : BaseEntity
    {
        public Guid HotelUUID { get; set; }
        public InfoType InfoType { get; set; }
        public string InfoContent { get; set; }
    }
}
