using System.ComponentModel.DataAnnotations;

namespace prjMaestroDetalle.Models
{
    public class ArticuloInventario
    {
        [Required(ErrorMessage = "Campo requerido")]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage = "Campo requerido")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public double PrecioCompra { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public double PrecioVenta { get; set; }
        public double ITBIs { get; set; }
    }
}