using Microsoft.AspNetCore.Mvc;
using DBAccess;

namespace HotelAPI.Controllers
{
    [ApiController]
    [Route("api/accomodation")]
    public class Accomodation : ControllerBase
    {
        private readonly ILogger<Accomodation> _logger;

        public Accomodation(ILogger<Accomodation> logger)
        {
            _logger = logger;
        }

        [HttpPut]
        public IActionResult CreateAccomodation()
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
        public IActionResult ReadAccomodation()
        {
            try
            {
                var am = new AccomodationManager();
                return StatusCode(200, am.Reply());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult UpdateAccomodation()
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
        public IActionResult DeleteAccomodation()
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