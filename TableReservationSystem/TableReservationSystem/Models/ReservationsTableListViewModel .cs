using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TableReservationSystem.Models
{
    public class ReservationsTableListViewModel
    {
        public Reservation Reservation { get; set; }
        public List<TableExtended> Tables { get; set; }
    }
}