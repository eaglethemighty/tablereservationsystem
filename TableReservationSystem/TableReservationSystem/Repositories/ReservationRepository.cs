using System.Collections.Generic;
using System.Linq;
using TableReservationSystem.Data;
using TableReservationSystem.Models;

namespace TableReservationSystem.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly TableReservationSystemContext _context;
        public ReservationRepository(TableReservationSystemContext context)
        {
            _context = context;
        }
        public void Create(Reservation reservation)
        {
            _context.Reservation.Add(reservation);
            _context.SaveChanges();
        }

        public List<Reservation> GetAllReservation()
            => _context.Reservation.ToList();
    }
}
