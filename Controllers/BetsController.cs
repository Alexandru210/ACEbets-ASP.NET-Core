﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ACEbets.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace ACEbets.Controllers
{
    [Authorize(Roles = "Admin, Member")]
    public class BetsController : Controller
    {
        private readonly BettingContext _context;

        public BetsController(BettingContext context)
        {
            _context = context;
        }

        // GET: Bets
        public async Task<IActionResult> Index()
        {
              return _context.Bets != null ? 
                          View(await _context.Bets.ToListAsync()) :
                          Problem("Entity set 'BettingContext.Bets'  is null.");
        }

        // GET: Bets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bets == null)
            {
                return NotFound();
            }

            var bet = await _context.Bets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bet == null)
            {
                return NotFound();
            }

            return View(bet);
        }

        // GET: Bets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Amount,Status")] Bet bet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bet);
        }

        // GET: Bets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Bets == null)
            {
                return NotFound();
            }

            var bet = await _context.Bets.FindAsync(id);
            if (bet == null)
            {
                return NotFound();
            }
            return View(bet);
        }

        // POST: Bets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Amount,Status")] Bet bet)
        {
            if (id != bet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BetExists(bet.Id))
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
            return View(bet);
        }

        // GET: Bets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Bets == null)
            {
                return NotFound();
            }

            var bet = await _context.Bets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bet == null)
            {
                return NotFound();
            }

            return View(bet);
        }

        // POST: Bets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Bets == null)
            {
                return Problem("Entity set 'BettingContext.Bets'  is null.");
            }
            var bet = await _context.Bets.FindAsync(id);
            if (bet != null)
            {
                _context.Bets.Remove(bet);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BetExists(int id)
        {
          return (_context.Bets?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
