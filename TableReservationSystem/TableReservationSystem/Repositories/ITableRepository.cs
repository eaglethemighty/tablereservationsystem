using System.Collections.Generic;
using TableReservationSystem.Models;

namespace TableReservationSystem.Repositories
{
    public interface ITableRepository
    {
        List<Table> GetAllTable();
    }
}
