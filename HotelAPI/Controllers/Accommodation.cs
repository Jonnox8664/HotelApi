using Microsoft.AspNetCore.Mvc;
using DBAccess.Manager;

namespace HotelAPI.Controllers
{
    [ApiController]
    [Route("api/accommodation")]
    public class Accommodation : ControllerBase
    {
        private readonly ILogger<Accommodation> _logger;

        public Accommodation(ILogger<Accommodation> logger)
        {
            _logger = logger;
        }

        [HttpPut]
        public IActionResult CreateAccommodation()
        {
            try
            {
                return StatusCode(200, "Create A");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult ReadAccommodation()
        {
            try
            {
                var am = new AccommodationManager();
                return StatusCode(200, am.Reply());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult UpdateAccommodation()
        {
            try
            {
                return StatusCode(200, "Update A");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteAccommodation()
        {
            try
            {
                return StatusCode(200, "Delete A");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}