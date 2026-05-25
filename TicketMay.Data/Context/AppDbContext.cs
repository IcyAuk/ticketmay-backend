using Microsoft.EntityFrameworkCore;
using TicketMay.Data.Context;

namespace TicketMay.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}