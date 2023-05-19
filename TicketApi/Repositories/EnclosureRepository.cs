using TicketApi.Data;
using TicketApi.Interfaces;
using TicketApi.Models;

namespace TicketApi.Repositories
{
    public class EnclosureRepository:GenericRepository<Enclosure>,IEnclosureRepository
    {
        private readonly ApplicationDbContext context;

        public EnclosureRepository(ApplicationDbContext context):base(context)
        {
            this.context = context;
        }

    }
}
