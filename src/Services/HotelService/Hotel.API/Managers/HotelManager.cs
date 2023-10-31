using AutoMapper;
using Hotel.API.Data;
using Hotel.API.Dtos;

namespace Hotel.API.Managers
{
    public class HotelManager : IHotelManager
    {
        private readonly HotelDbContext _context;
        private readonly IMapper _mapper;

        public HotelManager(HotelDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<HotelDto> CreateHotelAsync(HotelDtoForInsert hotelDtoForInsert)
        {
            var hotel = _mapper.Map<Entities.Hotel>(hotelDtoForInsert);
            await _context.AddAsync(hotel);
            await _context.SaveChangesAsync();
            return _mapper.Map<HotelDto>(hotel);
        }
    }
}
