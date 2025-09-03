using System;
using Domain;
using MediatR;
using Persistence;

namespace Application.Services.Commands;

public class CreateService
{
    public class Command : IRequest<string>
    {
        public required Service Service { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Command, string>
    {
        public async Task<string> Handle(Command request, CancellationToken cancellationToken)
        {
            context.Services.Add(request.Service);

            await context.SaveChangesAsync(cancellationToken);

            return request.Service.Id;
        }
    }
}
