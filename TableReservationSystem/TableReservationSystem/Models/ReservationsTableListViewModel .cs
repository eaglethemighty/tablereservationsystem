using System.Collections.Generic;

namespace TableReservationSystem.Models
{
    public class ReservationsTableListViewModel
    {
        public Reservation Reservation { get; set; }
        public List<TableStatus> Tables { get; set; }
    }
}