using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace prjMaestroDetalle.Models
{
    public class ArticuloFactura
    {
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string Nombre { get; set; }

         [Required(ErrorMessage = "Campo requerido")]
        public string Apellido { get; set; }

         [Required(ErrorMessage = "Campo requerido")]
        public string Cedula { get; set; }

        public int IdCliente { get; set; }
        public int IdCondicionPago { get; set; }
        public int IdEstado { get; set; }
        public int Cantidad { get; set; }
        public double ITBIs { get; set; }
        public double Valor { get; set; }
        public int IdArticulo { get; set; }
        public int IdFactura { get; set; }
        
        [StringLength(60)]
        public string Comentario { get; set; }

    }
}