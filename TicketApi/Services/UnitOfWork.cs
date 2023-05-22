using TicketApi.Data;
using TicketApi.Interfaces;

namespace TicketApi.Services
{
    public class UnitOfWork:IUnitOfWork

    {
        private readonly ApplicationDbContext applicationDbContext;
        public IEnclosureRepository Enclosure { get; }
        public IStadiumRepository Stadium { get; }
        public ISeatRepository Seat { get; }
        public IMatchRepsitory Match { get; }
        public ITicketRepository Ticket { get; }

        public UnitOfWork(ApplicationDbContext applicationDbContext,IEnclosureRepository enclosureRepository,IStadiumRepository stadiumRepository,
            ISeatRepository seatRepository,IMatchRepsitory matchRepsitory,ITicketRepository ticketRepository)
        {
            this.applicationDbContext = applicationDbContext;
            Enclosure = enclosureRepository;
            Stadium = stadiumRepository;
            Seat = seatRepository;
            Match = matchRepsitory;
            Ticket = ticketRepository;
        }

        public int Save()
        {
            return applicationDbContext.SaveChanges();
        }

        public void Dispose()
        {
            applicationDbContext.Dispose();
        }

    }
}
