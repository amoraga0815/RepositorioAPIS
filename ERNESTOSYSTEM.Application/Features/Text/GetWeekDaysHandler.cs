using MediatR;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOSYSTEM.Application.Features.Text
{
    public class GetWeekDaysHandler : IRequestHandler<GetWeekDaysQuery, IEnumerable<string>>
    {
        public Task<IEnumerable<string>> Handle(GetWeekDaysQuery request, CancellationToken cancellationToken)
        {
            var es = CultureInfo.GetCultureInfo("es-ES");
            var days = es.DateTimeFormat.DayNames.Select(d => d.ToUpper(es));
            return Task.FromResult(days);
        }
    }
}
