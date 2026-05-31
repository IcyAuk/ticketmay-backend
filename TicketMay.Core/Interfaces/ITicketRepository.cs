using TicketMay.Core.Entities;
namespace TicketMay.Core.Interfaces;

//Database calls are always async because they wait for database response. We use Task for this.
//An interface contains the methods and signature a class needs to have, without the implementation
public interface ITicketRepository
{
    Task<IEnumerable<Ticket>> GetAllAsync(); //IEnumerable is a collection of <T>
    Task<Ticket?> GetByIdAsync(int id);
    Task AddAsync(Ticket ticket);
    Task UpdateAsync(Ticket ticket);
    Task DeleteAsync(int id);
}