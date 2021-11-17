using System.Collections.Generic;
using System.Linq;
using TableReservationSystem.Data;
using TableReservationSystem.Models;

namespace TableReservationSystem.Repositories
{
    public class TableRepository : ITableRepository
    {
        private readonly TableReservationSystemContext _context;
        public TableRepository(TableReservationSystemContext context)
        {
            _context = context;
        }
        public List<Table> GetAllTable()
            => _context.Table.ToList();
    }
}
