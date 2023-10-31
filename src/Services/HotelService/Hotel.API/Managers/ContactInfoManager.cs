using AutoMapper;
using Hotel.API.Data;
using Hotel.API.Dtos;
using Hotel.API.Entities;
using Hotel.API.Managers.Abstract;
using Microsoft.EntityFrameworkCore;
using System;

namespace Hotel.API.Managers
{
    public class ContactInfoManager : IContactInfoManager
    {
        private readonly HotelDbContext _context;
        private readonly IMapper _mapper;

        public ContactInfoManager(HotelDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ContactInfoDto> CreateContactInfoAsync(ContactInfoDtoForInsert dtoForInsert)
        {
            var hotel = await _context.Hotels.Where(x => x.UUID == dtoForInsert.HotelUUID).FirstOrDefaultAsync();
            if (hotel != null)
            {
                var contactInfo = _mapper.Map<ContactInfo>(dtoForInsert);
                await _context.AddAsync(contactInfo);
                await _context.SaveChangesAsync();
                return _mapper.Map<ContactInfoDto>(contactInfo);
            }
            return null;

        }

        public async Task DeleteContactInfoAsync(Guid uuid)
        {
            var contactInfo = await _context.ContactInfos.Where(x => x.UUID == uuid).FirstOrDefaultAsync();
            if (contactInfo != null)
            {
                _context.Remove(contactInfo);
                _context.SaveChanges();
            }
        }
    }
}
