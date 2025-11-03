using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOSYSTEM.Application.Features.Text
{
    public record GetWeekDaysQuery() : IRequest<IEnumerable<string>>;
}
