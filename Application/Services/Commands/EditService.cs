using System;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Services.Commands;

public class EditService
{
    public class Command : IRequest
    {
        public required Service Service { get; set; }
    }

    public class Handler(AppDbContext context, IMapper mapper) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var service = await context.Services.FindAsync([request.Service.Id], cancellationToken) ?? throw new Exception("Cannot find activity");

            mapper.Map(request.Service, service);

            await context.SaveChangesAsync(cancellationToken);

            //return Unit.Value;
        }
    }
}
