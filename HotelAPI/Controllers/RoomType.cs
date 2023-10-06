using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [ApiController]
    [Route("api/roomtype")]
    public class RoomType : ControllerBase
    {
        private readonly ILogger<RoomType> _logger;

        public RoomType(ILogger<RoomType> logger)
        {
            _logger = logger;
        }

        [HttpPut]
        public IActionResult CreateRoomType()
        {
            try
            {
                return StatusCode(200, "Create R");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult ReadRoomType()
        {
            try
            {
                return StatusCode(200, "Read R");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult UpdateRoomType()
        {
            try
            {
                return StatusCode(200, "Update R");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteRoomType()
        {
            try
            {
                return StatusCode(200, "Delete R");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}