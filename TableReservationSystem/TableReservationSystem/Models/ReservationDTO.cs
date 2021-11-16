using System;
using System.ComponentModel.DataAnnotations;

namespace TableReservationSystem.Models
{
    public class ReservationDTO
    {
        public Table Table { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Duration Duration { get; set; }
    }
}
