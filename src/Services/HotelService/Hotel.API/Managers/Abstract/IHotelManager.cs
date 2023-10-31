using Hotel.API.Dtos;

namespace Hotel.API.Managers.Abstract
{
    public interface IHotelManager
    {
        Task<List<HotelDto>> GetHotelsAsync();
        Task<List<HotelWithDetailDto>> GetHotelsWithDetailAsync();
        Task<HotelDto> CreateHotelAsync(HotelDtoForInsert dtoForInsert);
        Task DeleteHotelAsync(Guid uuid);

    }
}
