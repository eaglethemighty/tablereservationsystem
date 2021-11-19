using System;
using System.ComponentModel.DataAnnotations;

namespace TableReservationSystem.Models
{
    public class ReservationDTO
    {
        public ReservationDTO(Reservation reservation)
        {
            Id = reservation.Id;
            TableID = (int)reservation.TableID;
            Date = reservation.Date;
            Duration = reservation.Duration;
        }

        public int Id { get; set; }
        public int TableID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        public Duration Duration { get; set; }
    }
}