using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment4V3.Data;
using Assignment4V3.Models;
using Microsoft.AspNetCore.Authorization;

namespace Assignment4V3.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reservations.Include(r => r.Room).Include(r => r.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.Room)
                .Include(r => r.User)
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
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "RoomNumber");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email");
            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserEmail,RoomId,CheckInDate,CheckOutDate")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                var existingreServation = _context.Reservations
                          .Where(b => b.RoomId == reservation.RoomId &&
              ((b.CheckInDate >= reservation.CheckInDate && b.CheckInDate <= reservation.CheckOutDate) ||
               (b.CheckOutDate >= reservation.CheckInDate && b.CheckOutDate <= reservation.CheckOutDate)))
                     .FirstOrDefault();

                if (existingreServation != null)
                {
                    ModelState.AddModelError(string.Empty, "The selected room is already booked for the selected date range.");
                    ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "RoomNumber", reservation.RoomId);
                    ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", reservation.UserId);
                    return View(reservation);
                }

                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "RoomNumber", reservation.RoomId);
            ViewData["UserEmail"] = new SelectList(_context.Users, "Id", "Id", reservation.UserId);
            return View(reservation);
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "RoomNumber", reservation.RoomId);
            ViewData["UserEmail"] = new SelectList(_context.Users, "Id", "Email", reservation.UserId);
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserEmail,RoomId,CheckInDate,CheckOutDate")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingreServation = _context.Reservations
                     .Where(b => b.Id != id && b.RoomId == reservation.RoomId &&
                           ((b.CheckInDate >= reservation.CheckInDate && b.CheckInDate <= reservation.CheckOutDate)
                             || (b.CheckOutDate >= reservation.CheckInDate && b.CheckOutDate <= reservation.CheckOutDate)))
                             .FirstOrDefault();

                if (existingreServation != null)
                {
                    ModelState.AddModelError(string.Empty, "The selected room is already booked for the selected date range.");
                    ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "RoomNumber", reservation.RoomId);
                    ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", reservation.UserId);
                    return View(reservation);
                }

                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "RoomType", reservation.RoomId);
            ViewData["UserEmail"] = new SelectList(_context.Users, "Id", "Id", reservation.UserId);
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.Room)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.Id == id);
        }
    }
}
