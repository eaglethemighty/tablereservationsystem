using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TableReservationSystem.Data;
using TableReservationSystem.Models;

namespace TableReservationSystem.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly TableReservationSystemContext _context;

        public ReservationsController(TableReservationSystemContext context)
        {
            _context = context;
        }

        // GET: Reservations index page
        public IActionResult Index()
        {
            return View();
        }

        // GET
        public async Task<IActionResult> LoadTables([FromBody] AjaxData ajaxData)
        {
            var tablesdb = await _context.Table.ToListAsync();
            var reservationdb = await _context.Reservation.Include(r => r.Table).ToListAsync();
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

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .Include(r => r.Table)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public IActionResult Create()
        {
            ViewData["TableID"] = new SelectList(_context.Table, "Id", "Id");
            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TableID,Date,Name,Surname,Email,Phone,Duration")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TableID"] = new SelectList(_context.Table, "Id", "Id", reservation.TableID);
            return View(reservation);
        }

        private Table GetTable(int id)
        {
            return _context.Table.FirstOrDefault(e => e.Id == id);
        }
    }
}
