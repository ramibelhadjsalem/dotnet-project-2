using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nakia_amal.Models;

namespace Nakia_amal.Controllers
{
    public class ActionController : Controller
    {
        private readonly DataContext _context;

        public ActionController(DataContext context)
        {
            _context = context;
        }
        // GET: ActionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ActionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ActionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ActionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ActionController/Edit/5
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

        // GET: ActionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ActionController/Delete/5
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
