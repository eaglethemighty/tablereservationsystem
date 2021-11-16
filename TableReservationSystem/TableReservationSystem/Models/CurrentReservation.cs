using System;
using System.ComponentModel.DataAnnotations;

namespace TableReservationSystem.Models
{
    public class CurrentReservation
    {
        public int Seats { get; set; }
        public Size Size { get; set; }
        public Shape Shape { get; set; }
        public bool HighChair { get; set; }
        public bool Window { get; set; }
        public Table Table { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public Duration Duration { get; set; }
    }
}
