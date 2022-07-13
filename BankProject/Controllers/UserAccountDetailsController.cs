using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BankProj.BankApplication;
using System.Security.Claims;

namespace BankProj.Controllers
{
    public class UserAccountDetailsController : Controller
    {
        private readonly AssignmentDBContext _context;

        public UserAccountDetailsController(AssignmentDBContext context)
        {
            _context = context;
        }

        // GET: UserAccountDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserAccountDetails.ToListAsync());
        }

        // GET: UserAccountDetails/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAccountDetail = await _context.UserAccountDetails
                .FirstOrDefaultAsync(m => m.Email == id);
            if (userAccountDetail == null)
            {
                return NotFound();
            }

            return View(userAccountDetail);
        }

        // GET: UserAccountDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserAccountDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FullName,DateofBirth,Email,Phone,City,State,AccountNumber")] UserAccountDetail userAccountDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userAccountDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userAccountDetail);
        }

        // GET: UserAccountDetails/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAccountDetail = await _context.UserAccountDetails.FindAsync(id);
            if (userAccountDetail == null)
            {
                return NotFound();
            }
            return View(userAccountDetail);
        }

        // POST: UserAccountDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FullName,DateofBirth,Email,Phone,City,State,AccountNumber")] UserAccountDetail userAccountDetail)
        {
            if (id != userAccountDetail.Email)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userAccountDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserAccountDetailExists(userAccountDetail.Email))
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
            return View(userAccountDetail);
        }

        // GET: UserAccountDetails/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAccountDetail = await _context.UserAccountDetails
                .FirstOrDefaultAsync(m => m.Email == id);
            if (userAccountDetail == null)
            {
                return NotFound();
            }

            return View(userAccountDetail);
        }

        // POST: UserAccountDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var userAccountDetail = await _context.UserAccountDetails.FindAsync(id);
            _context.UserAccountDetails.Remove(userAccountDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
       
        private bool UserAccountDetailExists(string id)
        {
            return _context.UserAccountDetails.Any(e => e.Email == id);
        }
    }
}
