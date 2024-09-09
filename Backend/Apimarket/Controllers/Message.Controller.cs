using APIADSO.Functions;
using APIADSO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIADSO.Controllers
{
    [ApiController]
    [Route("/Api/[controller]")]
    public class MessageController : Controller
    {
        // POST: Message/Edit/5
        [HttpPost]
        public IActionResult Mesagge(Persona persona)
        {
            try
            {
                var personaFunctions = new PersonaFunctions();
                var messageSaludo = personaFunctions.Saludo(persona.Name);
                return Ok(messageSaludo);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }    
    }
}
