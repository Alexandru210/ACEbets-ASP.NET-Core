using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ACEbets.Models;
using ACEbets.Services;
using BetService = ACEbets.Services.BetService;

namespace ACEbets.Controllers
{
    public class BetsController : Controller
    {
        private readonly BetService _betService;

        public BetsController(BetService betService)
        {
            _betService = betService;
        }

        // GET: Bets
        public IActionResult Index()
        {
            var bet = _betService.GetBet();
            return View(bet);
        }

        // GET: Bets/Details/5
     

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bet = _betService.GetBet()
                .FirstOrDefault(m => m.Id == id);
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
        //public async Task<IActionResult> Create([Bind("Id,Amount,Status")] Bet bet)
        public IActionResult Create([Bind("Id,Amount,Status")] Bet bet)
        {
            if (ModelState.IsValid)
            {
                _betService.AddBet(bet);
                _betService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(bet);
        }

        // GET: Bets/Edit/5

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bet = _betService.GetBet().FirstOrDefault(m => m.Id == id);
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
                    _betService.UpdateBet(bet);
                    _betService.Save();
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
        
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bet = _betService.GetBet()
                .FirstOrDefault(m => m.Id == id);
            if (bet == null)
            {
                return NotFound();
            }

            return View(bet);
        }

        // POST: Bets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        

        /*public IActionResult DeleteConfirmed(int id)
        {
            var bet = _betService.GetBetByCondition(b => b.BetId == id).FirstOrDefault();
            _betService.DeleteCompany(bet);
            _betService.Save();
            return RedirectToAction(nameof(Index));
        }*/

        private bool BetExists(int id)
        {
            return _betService.GetBet().Any(e => e.Id == id);
        }
    }
}
