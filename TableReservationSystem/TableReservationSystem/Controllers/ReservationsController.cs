using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TableReservationSystem.Models;
using TableReservationSystem.Repositories;

namespace TableReservationSystem.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly ITableRepository _tableRepository;

        public ReservationsController(IReservationRepository reservationRepository, ITableRepository tableRepository)
        {
            _reservationRepository = reservationRepository;
            _tableRepository = tableRepository;   
        }

        // GET: Reservations index page
        public IActionResult Index()
        {
            ReservationsIndexViewModel model = new() { Reservation = new()};
            return View(model);
        }

        // GET
        public IActionResult LoadTables([FromBody] AjaxData ajaxData)
        {
            var tablesdb = _tableRepository.GetAllTable();
            var reservationdb = _reservationRepository.GetAllReservation();
            List<ReservationDTO> reservations = new();
            List<TableStatus> tables = new();

            if (reservationdb != null)
            {
                foreach (var reservation in reservationdb)
                {
                    reservations.Add(new(reservation));
                }
            }
            if (tablesdb != null)
            {
                foreach (var table in tablesdb)
                {
                    tables.Add(new(table));
                }
            }
            var tablesOccupiedOnDay = reservations.Where(r => Math.Abs((r.Date - ajaxData.DateTime).TotalMinutes) <= 180).Select(t => t.TableID);

            foreach(var table in tables)
            {
                if (tablesOccupiedOnDay.Contains(table.Table.Id) || table.Table.Seats < ajaxData.Number)
                {
                    table.Available = false;
                }
            }
            tables = tables.OrderByDescending(x => x.Available).ThenBy(x => x.Table.Id).ToList();

            var viewModel = new ReservationsTableListViewModel { Tables = tables, Reservation = new Reservation { Date = ajaxData.DateTime} };

            return PartialView("_TableList", viewModel);
        }

        public async Task<IActionResult> LoadReservation([FromBody] AjaxData ajaxData)
        {
            var table = GetTable(ajaxData.Number);
            var tableDetails = new ReservationsTableDetailViewModel() { Table = table, Reservation = new() { Date = ajaxData.DateTime } };

            return await Task.FromResult(PartialView("_TableDetail", tableDetails));
        }
        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("TableID,Date,Name,Surname,Email,Phone,Duration")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _reservationRepository.Create(reservation);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        private Table GetTable(int id)
        {
            return _tableRepository.GetAllTable().FirstOrDefault(e => e.Id == id);
        }

        public Task<IActionResult> LoadTablesDetails([FromBody] AjaxData details)
        {
            return LoadReservation(details);
        }
    }
}
