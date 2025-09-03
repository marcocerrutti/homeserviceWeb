using System;
using MediatR;
using Persistence;

namespace Application.Services.Commands;

public class DeleteService
{
    public class Command : IRequest
    {
        public required string Id { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var service = await context.Services.FindAsync([request.Id], cancellationToken) ?? throw new Exception("Cannot find activity");

            context.Remove(service);

            await context.SaveChangesAsync(cancellationToken);
        }
    }
}