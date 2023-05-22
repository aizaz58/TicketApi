using TicketApi.Data;
using TicketApi.Interfaces;
using TicketApi.Models;

namespace TicketApi.Repositories
{
    public class MatchRepository:GenericRepository<Match>,IMatchRepsitory
    {
        public MatchRepository(ApplicationDbContext context):base(context)
        {
            
        }
    }
}
