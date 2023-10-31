using Hotel.API.Dtos;
using Hotel.API.Managers.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [ApiController]
    [Route("api/contactInfos")]
    public class ContactInfoController : ControllerBase
    {
        private readonly IContactInfoManager _contactInfoManager;

        public ContactInfoController(IContactInfoManager contactInfoManager)
        {
            _contactInfoManager = contactInfoManager;
        }

        [HttpPost]
        public async Task<IActionResult> CreateContactInfoAsync([FromBody] ContactInfoDtoForInsert dtoForInsert)
        {
            var hotel = await _contactInfoManager.CreateContactInfoAsync(dtoForInsert);
            return StatusCode(201, hotel);
        }

        [HttpDelete("{uuid}")]
        public async Task<IActionResult> DeleteContactInfoAsync([FromRoute(Name = "uuid")] Guid uuid)
        {
            await _contactInfoManager.DeleteContactInfoAsync(uuid);
            return NoContent();
        }

    }
}

