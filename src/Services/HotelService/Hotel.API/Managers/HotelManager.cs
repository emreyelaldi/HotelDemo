using AutoMapper;
using Hotel.API.Data;
using Hotel.API.Dtos;
using Hotel.API.Managers.Abstract;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<HotelDto>> GetHotelsAsync()
        {
            var hotelDtos = await _context
                .Hotels
                .Select(x => _mapper.Map<HotelDto>(x))
                .ToListAsync();
            return hotelDtos;
        }

        public async Task<List<HotelWithDetailDto>> GetHotelsWithDetailAsync()
        {
            var hotelsWithDetail = await _context
                 .Hotels
                 .Include(x => x.ContactInfos)
                  .Select(x => _mapper.Map<HotelWithDetailDto>(x))
                 .ToListAsync();
            return hotelsWithDetail;
        }

        public async Task<HotelDto> CreateHotelAsync(HotelDtoForInsert dtoForInsert)
        {
            var hotel = _mapper.Map<Entities.Hotel>(dtoForInsert);
            await _context.AddAsync(hotel);
            await _context.SaveChangesAsync();
            return _mapper.Map<HotelDto>(hotel);
        }

        public async Task DeleteHotelAsync(Guid uuid)
        {
            var hotel =await _context.Hotels.Where(x => x.UUID == uuid).Include(e => e.ContactInfos).FirstOrDefaultAsync();
            if (hotel != null)
            {
                _context.Remove(hotel);
                _context.SaveChanges();
            }
        }
    }
}
