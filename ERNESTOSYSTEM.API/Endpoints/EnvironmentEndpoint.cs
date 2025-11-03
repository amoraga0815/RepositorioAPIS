using ERNESTOSYSTEM.Application.Features.Environment;
using FastEndpoints;
using MediatR;

namespace ERNESTOSYSTEM.API.Endpoints
{
    public class EnvironmentEndpoint : EndpointWithoutRequest<EnvironmentResponse>
    {
        private readonly IMediator _mediator;
        public EnvironmentEndpoint(IMediator mediator) => _mediator = mediator;

        public override void Configure()
        {
            Get("environment");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var result = await _mediator.Send(new GetEnvironmentQuery(), ct);
            Response = result;
        }
    }
}
