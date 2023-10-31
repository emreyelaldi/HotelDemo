using Hotel.API.Dtos;

namespace Hotel.API.Managers
{
    public interface IHotelManager
    {
        Task<HotelDto> CreateHotelAsync(HotelDtoForInsert hotelDto);
    }
}
