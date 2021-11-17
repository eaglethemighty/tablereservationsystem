using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            return View();
        }

        // GET
        public IActionResult LoadTables([FromBody] AjaxData ajaxData)
        {
            var tablesdb = _tableRepository.GetAllTable();
            var reservationdb = _reservationRepository.GetAllReservation();
            List<ReservationDTO> reservations = new();
            List<TableExtended> tables = new();

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

            var tablesOccupiedOnDay = reservations.Where(r => r.Date - ajaxData.DateTime <= TimeSpan.FromMinutes(180)).Select(t => t.TableID);

            foreach(var table in tables)
            {
                if (tablesOccupiedOnDay.Contains(table.Table.Id) || table.Table.Seats < ajaxData.Number)
                {
                    table.Available = false;
                }
            }

            var viewModel = new ReservationsTableListViewModel { Tables = tables };

            return PartialView("_TableList", viewModel);
        }

        public IActionResult LoadReservation([FromBody] AjaxData ajaxData)
        {
            var table = GetTable(ajaxData.Number);
            var tableDetails = new ReservationsTableDetailViewModel() { Table = table, Reservation = new() { Date = ajaxData.DateTime } };

            return PartialView("_TableDetail", tableDetails);
        }

        // GET: Reservations/Create
        public IActionResult Create()
        {
            ViewData["TableID"] = new SelectList(_tableRepository.GetAllTable(), "Id", "Id");
            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("TableID,Date,Name,Surname,Email,Phone,Duration")] ReservationsTableDetailViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _reservationRepository.Create(viewModel.Reservation);
                return RedirectToAction(nameof(Index));
            }
            ViewData["TableID"] = new SelectList(_tableRepository.GetAllTable(), "Id", "Id", viewModel.Reservation.TableID);
            return View(viewModel);
        }

        private Table GetTable(int id)
        {
            return _tableRepository.GetAllTable().FirstOrDefault(e => e.Id == id);
        }
    }
}
