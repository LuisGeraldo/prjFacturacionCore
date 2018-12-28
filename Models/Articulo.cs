using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace prjMaestroDetalle.Models
{
    public class Articulo
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(60)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(60)]
        public string Descripcion { get; set; }
        public List<DetalleFactura> DetalleFactura { get; set; }
        public List<Inventario> Inventario { get; set; }
    }
}