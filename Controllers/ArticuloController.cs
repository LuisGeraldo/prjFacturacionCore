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
    public class ArticuloController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArticuloController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Articulo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Articulo.ToListAsync());
        }

        // GET: Articulo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.Articulo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (articulo == null)
            {
                return NotFound();
            }

            return View(articulo);
        }

        // GET: Articulo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Articulo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion, Existencia, PrecioCompra, PrecioVenta, ITBIs")] ArticuloInventario item)
        {
            if (ModelState.IsValid)
            {
                Articulo Articulo = new Articulo();
                Articulo.Nombre = item.Nombre;
                Articulo.Descripcion = item.Descripcion;
                _context.Articulo.Add(Articulo);
                await _context.SaveChangesAsync();

                Inventario Inventario = new Inventario();
                Inventario.IdArticulo = Articulo.Id;
                Inventario.Existencia = item.Existencia;
                Inventario.PrecioCompra = item.PrecioCompra;
                Inventario.PrecioVenta = item.PrecioVenta;
                Inventario.ITBIs = (item.PrecioVenta * 0.18);
                _context.Inventario.Add(Inventario);
                await _context.SaveChangesAsync();
            
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // GET: Articulo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.Articulo.FindAsync(id);
            if (articulo == null)
            {
                return NotFound();
            }
            return View(articulo);
        }

        // POST: Articulo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion")] Articulo articulo)
        {
            if (id != articulo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(articulo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticuloExists(articulo.Id))
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
            return View(articulo);
        }

        // GET: Articulo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.Articulo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (articulo == null)
            {
                return NotFound();
            }

            return View(articulo);
        }

        // POST: Articulo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var articulo = await _context.Articulo.FindAsync(id);
            _context.Articulo.Remove(articulo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticuloExists(int id)
        {
            return _context.Articulo.Any(e => e.Id == id);
        }
    }
}
