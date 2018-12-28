using Microsoft.EntityFrameworkCore;

namespace prjMaestroDetalle.Models
{
    public class ApplicationDbContext: DbContext
    {
       public ApplicationDbContext(DbContextOptions options): base(options)
       {

       }
       public DbSet<Articulo> Articulo { get; set; }
       public DbSet<Cliente> Cliente { get; set; }
       public DbSet<CondicionPago> CondicionPago { get; set; }
       public DbSet<DetalleFactura> DetalleFactura { get; set; }
       public DbSet<Estado> Estado { get; set; }
       public DbSet<Factura> Factura { get; set; }
       public DbSet<Inventario> Inventario { get; set; }
    }
}