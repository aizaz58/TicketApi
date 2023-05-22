using System.Runtime.InteropServices;
using TicketApi.Data;
using TicketApi.Interfaces;
using TicketApi.Models;

namespace TicketApi.Repositories
{
    public class SeatRepository:GenericRepository<Seat>,ISeatRepository
    {
        public SeatRepository(ApplicationDbContext context):base(context)
        {
            
        }
    }
}
