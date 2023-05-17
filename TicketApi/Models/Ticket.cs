using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TicketApi.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Match")]
        public int? MatchId { get; set; }
        public Match Matches { get; set; }
        [Required]
        [DisplayName("SeatNo")]
        public int? SeatId { get; set; }
        public Seat Seats { get; set; }


    }
}
