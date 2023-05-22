using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TicketApi.Models
{
    public class Stadium
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "name can be max 50 char long ."), MinLength(10, ErrorMessage = "name can be  min 10 char short.")]

        [DisplayName("Stadium Name")]
        public string Std_Name { get; set; }
        [DisplayName("City Name")]
        public string Std_CityName { get; set; }
        [DisplayName("Stadium Capacity")]
        public int Std_Capacity { get; set; }
       
        public  ICollection<Enclosure>? Enclosures { get; set; }
        public  ICollection<Match>? Matches { get; set; }


    }
}
