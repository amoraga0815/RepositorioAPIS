using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOSYSTEM.Application.Features.Text
{
 public class ToUpperHandler : IRequestHandler<ToUpperQuery, string>
    {
        public Task<string> Handle(ToUpperQuery request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.Input))
                return Task.FromResult(string.Empty);

            return Task.FromResult(request.Input.ToUpperInvariant());
        }
    }
}
