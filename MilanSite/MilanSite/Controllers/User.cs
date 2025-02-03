using Microsoft.AspNetCore.Mvc;

namespace MilanSite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ContentResult Get()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Content", "index.html"); // Assicurati di avere il file HTML in questa posizione
            var fileContents = System.IO.File.ReadAllText(filePath);
            return new ContentResult
            {
                Content = fileContents,
                ContentType = "text/html"
            };
        }

        [HttpPost("submit")]
        public IActionResult Submit([FromBody] UserDto user)
        {
            return Ok(new { Message = "Dati ricevuti", User = user });
        }
    }
}

