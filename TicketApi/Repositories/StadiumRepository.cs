﻿using TicketApi.Data;
using TicketApi.Interfaces;
using TicketApi.Models;

namespace TicketApi.Repositories
{
    public class StadiumRepository:GenericRepository<Stadium>,IStadiumRepository
    {
        public StadiumRepository(ApplicationDbContext context):base(context)
        {
            
        }
    }
}
