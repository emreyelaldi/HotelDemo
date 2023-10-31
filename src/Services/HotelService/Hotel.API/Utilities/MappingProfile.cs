using AutoMapper;
using Hotel.API.Dtos;

namespace Hotel.API.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HotelDtoForInsert, Entities.Hotel>();
            CreateMap<Entities.Hotel, HotelDto>();
            CreateMap<HotelDtoForUpdate, Entities.Hotel>();

        }
    }
}
