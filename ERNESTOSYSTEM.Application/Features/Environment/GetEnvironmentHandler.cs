using MediatR;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOSYSTEM.Application.Features.Environment
{
    public class GetEnvironmentHandler : IRequestHandler<GetEnvironmentQuery, EnvironmentResponse>
    {
        private readonly IHostEnvironment _env;
        private readonly IConfiguration _config;
        private readonly ILogger<GetEnvironmentHandler> _logger;

        public GetEnvironmentHandler(IHostEnvironment env, IConfiguration config, ILogger<GetEnvironmentHandler> logger)
        {
            _env = env;
            _config = config;
            _logger = logger;
        }

        public Task<EnvironmentResponse> Handle(GetEnvironmentQuery request, CancellationToken cancellationToken)
        {
            var envName = _env.EnvironmentName ?? "Sin Environment";
            var appName = _config["Application:Name"] ?? "ERNESTOSYSTEM";
            var appVersion = _config["Application:Version"] ?? "unknown";
            var message = _config["EnvironmentInfo:Message"] ?? $"Ejecutando en {envName}";

            _logger.LogInformation("Request environment: {env} - {app} {ver}", envName, appName, appVersion);

            var result = new EnvironmentResponse(envName, appName, appVersion, message);
            return Task.FromResult(result);
        }
    }
}
