using TicketApi.Interfaces;

namespace TicketApi.Services
{
    public interface IUnitOfWork:IDisposable
    {
        IStadiumRepository Stadium { get; }
        IEnclosureRepository Enclosure { get; }
        ISeatRepository Seat { get; }
        IMatchRepsitory Match { get; }
        ITicketRepository Ticket { get; }

        int Save();
    }
}
