using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prjMaestroDetalle.Models
{
    public class Inventario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public double ITBIs { get; set; }
        public int IdArticulo { get; set; }

        [ForeignKey("IdArticulo")]
        public Articulo Articulo { get; set; }
    }
}