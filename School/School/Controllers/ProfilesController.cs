using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class ProfilesController : Controller
    {
        private readonly SchoolDbContext _context;

        public ProfilesController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: Profiles
        public async Task<IActionResult> Index(string searchString)
        {
            var Profiles = from m in _context.profiles
                           select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                Profiles = Profiles.Where(s => s.City.Contains(searchString));
                return View(await Profiles.ToListAsync());
            }

            return View(await _context.profiles.ToListAsync());
        }

        // GET: Profiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Profile = await _context.profiles
                .FirstOrDefaultAsync(m => m.ProfileId == id);
            if (Profile == null)
            {
                return NotFound();
            }

            return View(Profile);
        }

        // GET: Profiles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Profiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProfileId,Name,BirthDate")] Profile profile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(profile);
        }

        // GET: Profiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Profile = await _context.profiles.FindAsync(id);
            if (Profile == null)
            {
                return NotFound();
            }
            return View(Profile);
        }

        // POST: Profiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProfileId,Name,BirthDate")] Profile Profile)
        {
            if (id != Profile.ProfileId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Profile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfileExists(Profile.ProfileId))
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
            return View(Profile);
        }

        // GET: Profiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Profile = await _context.profiles
                .FirstOrDefaultAsync(m => m.ProfileId == id);
            if (Profile == null)
            {
                return NotFound();
            }

            return View(Profile);
        }

        // POST: Profiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Profile = await _context.profiles.FindAsync(id);
            _context.profiles.Remove(Profile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfileExists(int id)
        {
            return _context.profiles.Any(e => e.ProfileId == id);
        }
    }
}
