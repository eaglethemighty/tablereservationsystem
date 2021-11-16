using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TableReservationSystem.Models
{
    public class ReservationsTableDetailViewModel
    {
        public Table Table { get; set; }
        public Reservation Reservation { get; set; }
    }
}