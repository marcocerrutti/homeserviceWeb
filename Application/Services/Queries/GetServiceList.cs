using System;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.Services.Queries;

public class GetServiceList
{
    public class Query : IRequest<List<Service>> { }

    public class Handler(AppDbContext context) : IRequestHandler<Query, List<Service>>
    {
        public async Task<List<Service>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await context.Services.ToListAsync(cancellationToken);
        }
    }
}
