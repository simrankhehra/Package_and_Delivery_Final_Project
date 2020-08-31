using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Package_and_Delivery_Final_Project.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Package_and_Delivery_Final_Project.Controllers
{
    public class PackagesController : Controller
    {
        private readonly Package_and_Delivery_Context _context;

        SignInManager<IdentityUser> SignInManager;

        public PackagesController(Package_and_Delivery_Context context,

            SignInManager<IdentityUser> SignInManager

            )
        {
            this.SignInManager = SignInManager;
            _context = context;
        }


        [Authorize(Roles = "admin,sender")]
        // GET: Packages
        public async Task<IActionResult> Index()
        {
            var package_and_Delivery_Context = _context.Package.Include(p => p.Courier).Include(p => p.Sender);

            if (SignInManager.IsSignedIn(User) && User.IsInRole("sender"))
            {

                return View(_context.Package.Include(p => p.Courier).Include(p => p.Sender).Where(p => p.Sender.Email.Equals(User.Identity.Name)).ToList());


            }

                return View(await package_and_Delivery_Context.ToListAsync());
            
        }

        // GET: Packages/Details/5
        [Authorize(Roles = "admin,sender")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Package
                .Include(p => p.Courier)
                .Include(p => p.Sender)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (package == null)
            {
                return NotFound();
            }

            return View(package);
        }

        // GET: Packages/Create
        [Authorize(Roles = "sender")]
        public IActionResult Create()
        {
            ViewData["CourierData"] = _context.Courier.ToList();
            
            return View();
        }

        // POST: Packages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "sender")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CourierId,Description,DeliveryAddress")] Package package)
        {


            if (SignInManager.IsSignedIn(User)) {

                var Sender = (from sender in _context.Sender
                              where sender.Email.Equals(User.Identity.Name)
                              select sender).FirstOrDefault();
                package.SenderId = Sender.Id;
                package.PackageStatus = PackageStatus.PENDING;
                package.Submitted = DateTime.Now;
            
            }
            ;
            if (ModelState.IsValid)
            {
                _context.Add(package);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourierId"] = new SelectList(_context.Courier, "Id", "Id", package.CourierId);
            ViewData["SenderId"] = new SelectList(_context.Set<Sender>(), "Id", "Id", package.SenderId);
            return View(package);
        }

        // GET: Packages/Edit/5

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Package.FindAsync(id);
            if (package == null)
            {
                return NotFound();
            }
            ViewData["CourierId"] = new SelectList(_context.Courier, "Id", "Name", package.CourierId);
            ViewData["SenderId"] = new SelectList(_context.Set<Sender>(), "Id", "SenderName", package.SenderId);

            ViewData["PackageStatus"] = new SelectList(Enum.GetValues(typeof(PackageStatus)), package.PackageStatus);
            return View(package);
        }

        // POST: Packages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CourierId,SenderId,Description,DeliveryAddress, PackageStatus")] Package package)
        {
            if (id != package.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(package);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PackageExists(package.Id))
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
            ViewData["CourierId"] = new SelectList(_context.Courier, "Id", "Id", package.CourierId);
            ViewData["SenderId"] = new SelectList(_context.Set<Sender>(), "Id", "Id", package.SenderId);
            return View(package);
        }

        // GET: Packages/Delete/5

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Package
                .Include(p => p.Courier)
                .Include(p => p.Sender)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (package == null)
            {
                return NotFound();
            }

            return View(package);
        }

        [Authorize(Roles = "admin")]
        // POST: Packages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var package = await _context.Package.FindAsync(id);
            _context.Package.Remove(package);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PackageExists(int id)
        {
            return _context.Package.Any(e => e.Id == id);
        }
    }
}
