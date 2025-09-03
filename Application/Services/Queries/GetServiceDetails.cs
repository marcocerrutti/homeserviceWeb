using System;
using Domain;
using MediatR;
using Persistence;

namespace Application.Services.Queries;

public class GetServiceDetails
{
    public class Query : IRequest<Service>
    {
        public required string Id { get; set; }
    }
    public class Handler(AppDbContext context) : IRequestHandler<Query, Service>
    {
        public async Task<Service> Handle(Query request, CancellationToken cancellationToken)
        {
            var service = await context.Services.FindAsync([request.Id], cancellationToken);

            if (service == null) throw new Exception("Service not Found");

            return service;
        }
    }
}
