using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using TicketApi.Models;

namespace TicketApi.DTOs.Stadium
{
    public class AddStadium
    {
       
       
        public string Std_Name { get; set; }
       
        public string Std_CityName { get; set; }
        
        public int Std_Capacity { get; set; }

        
    }
}
