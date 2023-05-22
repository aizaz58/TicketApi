using System.ComponentModel.DataAnnotations;

namespace TicketApi.Models
{
    public class Match
    {
        [Key]
        public int Id { get; set; }

        public string MatchName { get; set; }

        public DateTime MatchTime { get; set; }


        public ICollection<Ticket> Ticket { get; set; } = new List<Ticket>();

        public int StadiumId { get; set; }
        public virtual Stadium Stadiums { get; set; }
    }
}
