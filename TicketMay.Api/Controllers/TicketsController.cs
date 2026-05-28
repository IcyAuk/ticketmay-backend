using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TicketMay.Core.Entities;
using TicketMay.Core.Services;

namespace TicketMay.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TicketsController : ControllerBase
{
    public readonly TicketService _ticketService;
    public TicketsController (TicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var tickets = await _ticketService.GetAllTicketsAsync();
        return Ok(tickets);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var ticket = await _ticketService.GetTicketByIdAsync(id);
        if (ticket == null) return NotFound();
        return Ok(ticket);
    }
    [HttpPost]
    public async Task<IActionResult> Create(Ticket ticket)
    {
        await _ticketService.CreateTicketAsync(ticket);
        return CreatedAtAction(nameof(GetById), new {id = ticket.Id}, ticket);//retusn a 201 Created that includes the created object and where it can be fetched
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Ticket ticket)
    {
        if (id != ticket.Id) return BadRequest();
        await _ticketService.UpdateTicketAsync(ticket);
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _ticketService.DeleteTicketAsync(id);
        return NoContent();
    }

}