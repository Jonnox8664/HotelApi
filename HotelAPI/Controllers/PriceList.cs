using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [ApiController]
    [Route("api/pricelist")]
    public class PriceList : ControllerBase
    {
        private readonly ILogger<PriceList> _logger;

        public PriceList(ILogger<PriceList> logger)
        {
            _logger = logger;
        }

        [HttpPut]
        public IActionResult CreatePriceList()
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
        public IActionResult ReadPriceList()
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
        public IActionResult UpdatePriceList()
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
        public IActionResult DeletePriceList()
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