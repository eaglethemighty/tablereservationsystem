using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TableReservationSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [ForeignKey("Table")]
        public int? TableID { get; set; }
        public Table Table { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Date { get; set; }

        [StringLength(30, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }

        [StringLength(30, MinimumLength = 1)]
        [Required]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        public Duration Duration { get; set; }
    }
}