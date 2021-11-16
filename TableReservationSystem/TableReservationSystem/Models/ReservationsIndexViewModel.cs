using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TableReservationSystem.Models
{
    public class ReservationsIndexViewModel
    {
        public Reservation Reservation { get; set; }
        public int Seats { get; set; }
    }
}