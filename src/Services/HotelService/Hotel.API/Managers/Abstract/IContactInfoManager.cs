using Hotel.API.Dtos;

namespace Hotel.API.Managers.Abstract
{
    public interface IContactInfoManager
    {
        Task<ContactInfoDto> CreateContactInfoAsync(ContactInfoDtoForInsert dtoForInsert);
        Task DeleteContactInfoAsync(Guid uuid);
    }
}
