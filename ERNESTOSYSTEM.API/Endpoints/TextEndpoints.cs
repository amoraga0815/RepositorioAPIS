using FastEndpoints;
using MediatR;
using ERNESTOSYSTEM.Application.Features.Text;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ERNESTOSYSTEM.API.Endpoints
{
    public class ToUpperRequest
    {
        public string Input { get; set; } = string.Empty;
    }

    public class ToUpperEndpoint : Endpoint<ToUpperRequest, string>
    {
        private readonly IMediator _mediator;

        public ToUpperEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        public override void Configure()
        {
            Post("text/toupper");
            AllowAnonymous();
        }

        public override async Task HandleAsync(ToUpperRequest req, CancellationToken ct)
        {
            var result = await _mediator.Send(new ToUpperQuery(req.Input), ct);
            Response = result;
        }
    }

    public class WeekDaysEndpoint : EndpointWithoutRequest<IEnumerable<string>>
    {
        private readonly IMediator _mediator;
        public WeekDaysEndpoint(IMediator mediator) => _mediator = mediator;

        public override void Configure()
        {
            Get("text/weekdays");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var result = await _mediator.Send(new GetWeekDaysQuery(), ct);
            Response = result;
        }
    }
}
