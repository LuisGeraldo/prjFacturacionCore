using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace prjMaestroDetalle.Models
{
    public class CondicionPago
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(60)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(60)]
        public string Descripcion { get; set; }
        public List<Factura> Factura { get; set; }
    }
}