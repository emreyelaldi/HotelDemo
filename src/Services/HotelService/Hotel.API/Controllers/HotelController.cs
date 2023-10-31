using Hotel.API.Dtos;
using Hotel.API.Managers.Abstract;
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

        [HttpGet]
        public async Task<IActionResult> GetHotelsAsync()
        {
            var hotels = await _hotelManager.GetHotelsAsync();
            return Ok(hotels);
        }

        [HttpGet("withDetail")]
        public async Task<IActionResult> GetHotelsWithDetailAsync()
        {
            var hotels = await _hotelManager.GetHotelsWithDetailAsync();
            return Ok(hotels);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHotelAsync([FromBody] HotelDtoForInsert dtoForInsert)
        {
            var hotel = await _hotelManager.CreateHotelAsync(dtoForInsert);
            return StatusCode(201, hotel);
        }

        [HttpDelete("{uuid}")]
        public async Task<IActionResult> DeleteHotelAsync([FromRoute(Name = "uuid")] Guid uuid)
        {
            await _hotelManager.DeleteHotelAsync(uuid);
            return NoContent();
        }
    }
}