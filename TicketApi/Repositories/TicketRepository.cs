using TicketApi.Data;
using TicketApi.Interfaces;
using TicketApi.Models;

namespace TicketApi.Repositories
{
    public class TicketRepository:GenericRepository<Ticket>,ITicketRepository
    {
        public TicketRepository(ApplicationDbContext context):base(context)

        {
            
        }
    }
}
