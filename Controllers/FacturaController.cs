using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prjMaestroDetalle.Models;

namespace prjMaestroDetalle.Controllers
{
    public class FacturaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public List<DetalleFactura> listDetalleFactura = new List<DetalleFactura>();
        public FacturaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Factura
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Factura.Include(f => f.CondicionPago).Include(f => f.Estado).Include(f => f.cliente);
            return View(await applicationDbContext.ToListAsync());
        }


        public ActionResult Create()
        {
            ViewData["IdCondicionPago"] = new SelectList(_context.CondicionPago, "Id", "Nombre");
            ViewData["IdEstado"] = new SelectList(_context.Estado, "Id", "Nombre");
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Nombre");
            ViewData["IdArticulo"] = new SelectList(_context.Articulo, "Id", "Nombre");
        
            return View();
        }
        // GET: Factura/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            

            var detalleFactura = _context.DetalleFactura.Include(d => d.Articulo).Include(d => d.Factura).Where(x => x.IdFactura == id);
            var Factura = _context.Factura.FirstOrDefault(x => x.Id == id);
            
            ViewData["idFactura"] = Factura.Id;
            ViewData["Fecha"] = Factura.Fecha;
            ViewData["Cliente"] = _context.Cliente.FirstOrDefault(x => x.Id == Factura.IdCliente).Nombre;
            ViewData["CondicionPago"] = _context.CondicionPago.FirstOrDefault(x => x.Id == Factura.IdCondicionPago).Nombre;
            ViewData["CantidadArticulo"] = Factura.CantidadArticulo;
            ViewData["subTotal"] = Factura.SubTotal;
            ViewData["Total"] = Factura.Total;
            ViewData["Estado"] = _context.Cliente.FirstOrDefault(x => x.Id == Factura.IdEstado).Nombre;
            
            return View(await detalleFactura.ToListAsync());
        }


        // GET: Factura/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Factura.FindAsync(id);
            if (factura == null)
            {
                return NotFound();
            }
            ViewData["IdCondicionPago"] = new SelectList(_context.CondicionPago, "Id", "Nombre", factura.IdCondicionPago);
            ViewData["IdEstado"] = new SelectList(_context.Estado, "Id", "Nombre", factura.IdEstado);
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Nombre", factura.IdCliente);
            return View(factura);
        }

        // POST: Factura/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fecha,IdCliente,IdCondicionPago,CantidadArticulo,SubTotal,Total,IdEstado")] Factura factura)
        {
            if (id != factura.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(factura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacturaExists(factura.Id))
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
            ViewData["IdCondicionPago"] = new SelectList(_context.CondicionPago, "Id", "Nombre", factura.IdCondicionPago);
            ViewData["IdEstado"] = new SelectList(_context.Estado, "Id", "Nombre", factura.IdEstado);
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Nombre", factura.IdCliente);
            return View(factura);
        }

        // GET: Factura/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Factura
                .Include(f => f.CondicionPago)
                .Include(f => f.Estado)
                .Include(f => f.cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factura == null)
            {
                return NotFound();
            }

            return View(factura);
        }

        // POST: Factura/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var factura = await _context.Factura.FindAsync(id);
            _context.Factura.Remove(factura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       [HttpPost] 
        public ActionResult UpdateOrder() 
        { 
        // some code 
        return Json(new { success = true, message = "Order updated successfully" }); 
        } 

        private bool FacturaExists(int id)
        {
            return _context.Factura.Any(e => e.Id == id);
        }

        [HttpPost]
        public JsonResult Agregar(List<DetalleFactura> ArticulosValues, Factura FacturaHeader)
        {
            try
            {
                FacturaHeader.Fecha =  DateTime.UtcNow;
                _context.Factura.Add(FacturaHeader);
                _context.SaveChanges();

                foreach(var item in ArticulosValues){ 

                var Inventario = _context.Inventario.FirstOrDefault(x => x.IdArticulo == item.IdArticulo);
                _context.DetalleFactura.Add(new DetalleFactura(item.Cantidad, (item.Cantidad * Inventario.ITBIs), Inventario.PrecioVenta, item.IdArticulo, FacturaHeader.Id));
                _context.SaveChanges();

                FacturaHeader.SubTotal += (item.Cantidad * Inventario.PrecioVenta);
           
                FacturaHeader.Total += ((item.Cantidad * Inventario.PrecioVenta) + (Inventario.ITBIs * item.Cantidad));
                FacturaHeader.CantidadArticulo += item.Cantidad;
                _context.Factura.Attach(FacturaHeader);
                _context.SaveChanges();

                if(Inventario.Existencia >= item.Cantidad){
                    Inventario.Existencia = Inventario.Existencia - item.Cantidad;
                }

                _context.Inventario.Attach(Inventario);
                _context.SaveChanges();

                }

                return Json(new {success = true, message = "Factura realizada", subtotal = FacturaHeader.SubTotal, total = FacturaHeader.Total });
            }

            catch(Exception ex)
            {
                return Json(new {success = false, message = "Factura no realizada", error = ex});
            }
        }

        [HttpPost]
        public JsonResult Consultar(int IdArticulo)
        {
            var Articulo = _context.Inventario.FirstOrDefault(x => x.IdArticulo == IdArticulo);
            return Json(new {success = true, Articulo = Articulo});
        }
    }
}
