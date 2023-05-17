using Microsoft.EntityFrameworkCore;
using TicketApi.Models;

namespace TicketApi.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Enclosure> Enclosures { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Match> Matches { get; set; }

    }
}
