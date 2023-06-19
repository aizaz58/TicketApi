using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq.Expressions;
using TicketApi.Data;
using TicketApi.Interfaces;
using TicketApi.Models;

namespace TicketApi.Repositories
{
    public class StadiumRepository:GenericRepository<Stadium>,IStadiumRepository
    {
        private readonly ApplicationDbContext context;

        public StadiumRepository(ApplicationDbContext context):base(context)
        {
            this.context = context;
        }

        public IQueryable<Stadium> IncludeOther(string[] Tab)
        {
            IQueryable<Stadium> Stadiums = context.Stadiums;
            foreach (string item in Tab)
            {
                Stadiums = Stadiums.Include(item);
            }
            return Stadiums;
        }
    }
    }

