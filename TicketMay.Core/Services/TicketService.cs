using TicketMay.Core.Interfaces;
using TicketMay.Core.Entities;


namespace TicketMay.Core.Services;

//Business Layer - Allows added logic before returning repository operations
public class TicketService
{
    private readonly ITicketRepository _ticketRepository; //field
    public TicketService(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    public async Task<IEnumerable<Ticket>> GetAllTicketsAsync()
    {
        return await _ticketRepository.GetAllAsync();
    }

    public async Task<Ticket?> GetTicketByIdAsync(int id)
    {
        return await _ticketRepository.GetByIdAsync(id);
    }

    public async Task CreateTicketAsync(Ticket ticket)
    {
        await _ticketRepository.AddAsync(ticket);
    }

    public async Task UpdateTicketAsync(Ticket ticket)
    {
        await _ticketRepository.UpdateAsync(ticket);
    }

    public async Task DeleteTicketAsync(int id)
    {
        await _ticketRepository.DeleteAsync(id);
    }
}