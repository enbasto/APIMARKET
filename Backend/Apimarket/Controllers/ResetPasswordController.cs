using APIADSO.Models;
using APIADSO.Functions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace APIADSO.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ResetPasswordController : Controller
    {
        
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel resetPassword)
        {
            try
            {
               MethodosFunctions functions = new MethodosFunctions();
                var envio = await functions.SendEmail(resetPassword.Email);
                if (envio.Status == true)
                {
                    return Ok(envio);

                }
                 return NotFound(envio);
            }
            catch(Exception ex)
            {
                //log
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }

        
    }
}
