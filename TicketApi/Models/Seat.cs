﻿using System.ComponentModel.DataAnnotations;

namespace TicketApi.Models
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SeatNo { get; set; }

        [Required]
        public int SeatPrice { get; set; }


        public ICollection<Ticket> Ticket { get; set; }
        public int EnclosureId { get; set; }
        public Enclosure Enclosures { get; set; }

    }
}
