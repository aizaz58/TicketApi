using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TicketApi.DTOs.Stadium
{
    public class UpdateStadium
    {
 
        public int Id { get; set; }
      
        public string Std_Name { get; set; }
     
        public string Std_CityName { get; set; }
       
        public int Std_Capacity { get; set; }


    }
}
