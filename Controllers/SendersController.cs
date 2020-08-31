using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Package_and_Delivery_Final_Project.Models;

namespace Package_and_Delivery_Final_Project.Controllers
{
    [Authorize(Roles = "admin")]
    public class SendersController : Controller
    {
        private readonly Package_and_Delivery_Context _context;

        public SendersController(Package_and_Delivery_Context context)
        {
            _context = context;
        }

        // GET: Senders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sender.ToListAsync());
        }

        // GET: Senders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sender = await _context.Sender
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sender == null)
            {
                return NotFound();
            }

            return View(sender);
        }

        // GET: Senders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Senders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SenderName,PhoneNumber,Email")] Sender sender)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sender);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sender);
        }

        // GET: Senders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sender = await _context.Sender.FindAsync(id);
            if (sender == null)
            {
                return NotFound();
            }
            return View(sender);
        }

        // POST: Senders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SenderName,PhoneNumber,Email")] Sender sender)
        {
            if (id != sender.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sender);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SenderExists(sender.Id))
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
            return View(sender);
        }

        // GET: Senders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sender = await _context.Sender
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sender == null)
            {
                return NotFound();
            }

            return View(sender);
        }

        // POST: Senders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sender = await _context.Sender.FindAsync(id);
            _context.Sender.Remove(sender);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SenderExists(int id)
        {
            return _context.Sender.Any(e => e.Id == id);
        }
    }
}
