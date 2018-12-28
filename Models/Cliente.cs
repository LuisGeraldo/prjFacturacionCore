using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace prjMaestroDetalle.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(60)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(60)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(11, ErrorMessage ="Maximo 11 digitos", MinimumLength = 11)]
  
        public string Cedula { get; set; }
        public List<Factura> Factura { get; set; }
    }
}