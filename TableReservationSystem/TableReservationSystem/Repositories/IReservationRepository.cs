﻿using System.Collections.Generic;
using TableReservationSystem.Models;

namespace TableReservationSystem.Repositories
{
    interface IReservationRepository
    {
        void Create(Reservation reservation);
        List<Reservation> GetAllReservation();
    }
}
