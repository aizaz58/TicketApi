using AutoMapper;
using TicketApi.DTOs.Stadium;
using TicketApi.Models;

namespace TicketApi
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Stadium, GetStadium>();
            CreateMap<AddStadium, Stadium>();
            CreateMap< UpdateStadium,Stadium>();
        }
    }
}
