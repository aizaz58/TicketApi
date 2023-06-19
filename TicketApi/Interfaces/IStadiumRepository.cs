using System.Linq.Expressions;
using TicketApi.Models;

namespace TicketApi.Interfaces
{
    public interface IStadiumRepository:IGenericRepository<Stadium>
    {
        public IQueryable<Stadium> IncludeOther(String[] Tab);
    }
}
