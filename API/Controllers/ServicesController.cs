using Application.Services.Commands;
using Application.Services.Queries;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers;

public class ServicesController : BaseApiController
{
    // Controller actions go here
    [HttpGet]
    public async Task<ActionResult<List<Service>>> GetServices()
    {
        return await Mediator.Send(new GetServiceList.Query());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Service>> GetServiceDetail(string id)
    {
        return await Mediator.Send(new GetServiceDetails.Query { Id = id });
    }

    [HttpPost]
    public async Task<ActionResult<string>> CreateService(Service service)
    {
        return await Mediator.Send(new CreateService.Command { Service = service });
    }

    [HttpPut]
    public async Task<ActionResult> EditService(Service service)
    {
        await Mediator.Send(new EditService.Command { Service = service });

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteService(string id)
    {
        await Mediator.Send(new DeleteService.Command { Id = id });

        return Ok();
    }
}
