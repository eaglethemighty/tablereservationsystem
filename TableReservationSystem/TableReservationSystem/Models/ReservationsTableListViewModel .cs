using System.Collections.Generic;

namespace TableReservationSystem.Models
{
    public class ReservationsTableListViewModel
    {
        public Reservation Reservation { get; set; }
        public List<TableExtended> Tables { get; set; }
    }
}