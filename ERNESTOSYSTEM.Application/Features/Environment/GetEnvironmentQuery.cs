using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOSYSTEM.Application.Features.Environment
{
    public record GetEnvironmentQuery() : IRequest<EnvironmentResponse>;

    public record EnvironmentResponse(
        string Environment,
        string Application,
        string Version,
        string Message
    );
}
