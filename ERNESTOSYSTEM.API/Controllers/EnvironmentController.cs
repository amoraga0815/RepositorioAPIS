using Microsoft.AspNetCore.Mvc;

namespace ERNESTOSYSTEM.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnvironmentController : ControllerBase
    {
        private readonly IHostEnvironment _env;
        private readonly IConfiguration _config;
        private readonly ILogger<EnvironmentController> _logger;

        public EnvironmentController(IHostEnvironment env, IConfiguration config, ILogger<EnvironmentController> logger)
        {
            _env = env;
            _config = config;
            _logger = logger;
        }

        // GET /Environment
        [HttpGet]
        public ActionResult Get()
        {
            var envName = _env.EnvironmentName ?? "Sin Environment";
            var appName = _config["Application:Name"] ?? "ERNESTOSYSTEM";
            var appVersion = _config["Application:Version"] ?? "unknown";
            var message = _config["EnvironmentInfo:Message"] ?? $"Ejecutando en {envName}";

            var result = new
            {
                Environment = envName,
                Application = appName,
                Version = appVersion,
                Message = message
            };

            _logger.LogInformation("Request environment: {env} - {app} {ver}", envName, appName, appVersion);

            return Ok(result);
        }
    }
}
