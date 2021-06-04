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
    public class TeachersController : Controller
    {
        private readonly SchoolDbContext _context;

        public TeachersController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: Teachers
        public async Task<IActionResult> Index(string searchString)
        {
            var Teachers = from m in _context.teachers
                           select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                Teachers = Teachers.Where(s => s.Name.Contains(searchString));
                return View(await Teachers.ToListAsync());
            }

            return View(await _context.teachers.ToListAsync());
        }

        // GET: Teachers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Teacher = await _context.teachers
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (Teacher == null)
            {
                return NotFound();
            }

            return View(Teacher);
        }

        // GET: Teachers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teachers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeacherId,Name,BirthDate")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teacher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teacher);
        }

        // GET: Teachers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Teacher = await _context.teachers.FindAsync(id);
            if (Teacher == null)
            {
                return NotFound();
            }
            return View(Teacher);
        }

        // POST: Teachers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TeacherId,Name,BirthDate")] Teacher Teacher)
        {
            if (id != Teacher.TeacherId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Teacher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherExists(Teacher.TeacherId))
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
            return View(Teacher);
        }

        // GET: Teachers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Teacher = await _context.teachers
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (Teacher == null)
            {
                return NotFound();
            }

            return View(Teacher);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Teacher = await _context.teachers.FindAsync(id);
            _context.teachers.Remove(Teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherExists(int id)
        {
            return _context.teachers.Any(e => e.TeacherId == id);
        }

    }
}
