using Microsoft.EntityFrameworkCore;
using TicketMay.Core.Entities;
using TicketMay.Data.Context;

namespace TicketMay.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Ticket> Tickets {get;set;} //define table Tickets
}