

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nakia_amal.Models;

namespace Nakia_amal.Controllers
{
    public class ReclamationController : Controller
    {
        private readonly DataContext _context;

        public ReclamationController(DataContext context)
        {
            _context = context;
        }
        // GET: ReclamationController
        public async Task<ActionResult> Index()
        {
            var helpDeskDbContext = _context.Reclamations.Include(r => r.User);
            return View(await helpDeskDbContext.ToListAsync());
        }

        // GET: ReclamationController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Reclamations == null)
            {
                return NotFound();
            }

            var reclamation = await _context.Reclamations
                .Include(r => r.User)
                .FirstOrDefaultAsync(r => r.Id == id);
            if ( reclamation == null)
            {
                return NotFound();
            }

            return View( reclamation);
        }

        // GET: ReclamationController/Create
        public ActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

        // POST: ReclamationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id","Name", "Description", "Etat", "UserId")] Reclamation reclamation)
        {
            try
            {
                _context.Add(reclamation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewData["UserId"] = new SelectList( _context.Reclamations, "Id", "Name", reclamation.UserId);
                return View(reclamation);

            }

        }

        // GET: ReclamationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReclamationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReclamationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReclamationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
