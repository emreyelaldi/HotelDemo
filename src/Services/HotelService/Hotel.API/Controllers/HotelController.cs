using Hotel.API.Dtos;
using Hotel.API.Managers;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [ApiController]
    [Route("api/hotels")]
    public class HotelController : ControllerBase
    {
        private readonly IHotelManager _hotelManager;
        public HotelController(IHotelManager hotelManager)
        {
            _hotelManager = hotelManager;
        }

        [HttpPost(Name = "CreateHotelAsync")]
        public async Task<IActionResult> CreateHotelAsync([FromBody] HotelDtoForInsert hotelDtoForInsert)
        {
            var hotel = await _hotelManager.CreateHotelAsync(hotelDtoForInsert);
            return StatusCode(201, hotel);
        }

    }
}