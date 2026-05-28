using TicketMay.Core.Interfaces;
using TicketMay.Core.Entities;
using TicketMay.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace TicketMay.Data.Repositories;

public class TicketRepository : ITicketRepository
{
    private readonly AppDbContext _context; //declares a field on the class

    //constructor signature -- needs AppDbContext called context -- ASP.NET automatically injects dependency
    //_context is of type AppDbContext which inherits from DbContext
    public TicketRepository(AppDbContext context) 
    {
        _context = context; //stores AppDbContext context in field _context for all methods to use
    }

    public async Task<IEnumerable<Ticket>> GetAllAsync()
    {
        return await _context.Tickets.ToListAsync();
    }

    public async Task<Ticket?> GetByIdAsync(int id)
    {
        return await _context.Tickets.FindAsync(id);
    }

    public async Task AddAsync(Ticket ticket)
    {
        await _context.Tickets.AddAsync(ticket);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Ticket ticket)
    {
        _context.Tickets.Update(ticket);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var ticket = await GetByIdAsync(id);
        if (ticket != null)
        {
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();
        }
    }
}