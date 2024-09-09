using APIADSO.Functions;
using APIADSO.Models;
using Microsoft.AspNetCore.Mvc;
namespace APIADSO.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class SendEmailController : Controller
    {
        public GeneralFunctions FunctionsGeneral;
        public SendEmailController(IConfiguration configuration) 
        {
            FunctionsGeneral = new GeneralFunctions(configuration);
        }
        [HttpPost("SendEmail")]
        public IActionResult SendEmail(SendEmail EmailSend)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                FunctionsGeneral.AddLog(ex.ToString());
                return StatusCode(500, ex.Message);
            }
        }
    }

    
}
