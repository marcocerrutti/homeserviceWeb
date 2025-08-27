using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class ServicesController(AppDbContext context) : BaseApiController
{
    // Controller actions go here
    [HttpGet]
    public async Task<ActionResult<List<Service>>> GetServices()
    {
        return await context.Services.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Service>> GetServiceDetail(string id)
    {
        var service = await context.Services.FindAsync(id);
        if (service == null) return NotFound();
        return service;
    }
}
