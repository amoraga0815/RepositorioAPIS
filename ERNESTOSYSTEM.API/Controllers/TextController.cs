using Microsoft.AspNetCore.Mvc;

namespace ERNESTOSYSTEM.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TextController : ControllerBase
    {
        private readonly ILogger<TextController> _logger;

        public TextController(ILogger<TextController> logger)
        {
            _logger = logger;
        }

        // GET /Text/toupper/{input}
        [HttpGet("toupper/{input}")]
        public ActionResult<string> ToUpper(string input)
        {
            var result = TextService.ToUpper(input);
            return Ok(result);
        }

        // GET /Text/weekdays
        [HttpGet("weekdays")]
        public ActionResult<IEnumerable<string>> GetWeekDays()
        {
            var days = TextService.GetWeekDays();
            return Ok(days);
        }
    }
}
