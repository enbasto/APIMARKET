using APIADSO.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIADSO.Controllers
{
	[ApiController]
	[Route("Api/[controller]")]
    public class NumberController : Controller
    {
		[HttpPost("CreateNumber")]
        public IActionResult CreateNumber(NumberModel number)
        {
			try
			{

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message.ToString());
			}
			return Ok();
        }
        [HttpGet("GetNumbers")]
        public IActionResult GetNumbers()
        {
            try
            {

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            return Ok();
        }

        [HttpGet("GetNumber")]
        public IActionResult GetNumber()
        {
            try
            {

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            return Ok();
        }

        [HttpPost("UpdateNumber")]
        public IActionResult UpdateNumber(NumberModel number)
        {
            try
            {

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            return Ok();
        }
        [HttpDelete("DeleteNumber")]
        public IActionResult DeleteNumber()
        {
            try
            {

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            return Ok();
        }
    }
}
