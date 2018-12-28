using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prjMaestroDetalle.Models;

namespace prjMaestroDetalle.Controllers
{
    public class CondicionPagoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CondicionPagoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CondicionPago
        public async Task<IActionResult> Index()
        {
            return View(await _context.CondicionPago.ToListAsync());
        }

        // GET: CondicionPago/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var condicionPago = await _context.CondicionPago
                .FirstOrDefaultAsync(m => m.Id == id);
            if (condicionPago == null)
            {
                return NotFound();
            }

            return View(condicionPago);
        }

        // GET: CondicionPago/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CondicionPago/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion")] CondicionPago condicionPago)
        {
            if (ModelState.IsValid)
            {
                _context.Add(condicionPago);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(condicionPago);
        }

        // GET: CondicionPago/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var condicionPago = await _context.CondicionPago.FindAsync(id);
            if (condicionPago == null)
            {
                return NotFound();
            }
            return View(condicionPago);
        }

        // POST: CondicionPago/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion")] CondicionPago condicionPago)
        {
            if (id != condicionPago.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(condicionPago);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CondicionPagoExists(condicionPago.Id))
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
            return View(condicionPago);
        }

        // GET: CondicionPago/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var condicionPago = await _context.CondicionPago
                .FirstOrDefaultAsync(m => m.Id == id);
            if (condicionPago == null)
            {
                return NotFound();
            }

            return View(condicionPago);
        }

        // POST: CondicionPago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var condicionPago = await _context.CondicionPago.FindAsync(id);
            _context.CondicionPago.Remove(condicionPago);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CondicionPagoExists(int id)
        {
            return _context.CondicionPago.Any(e => e.Id == id);
        }
    }
}
