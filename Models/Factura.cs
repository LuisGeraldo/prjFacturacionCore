using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prjMaestroDetalle.Models
{
    public class Factura
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente cliente { get; set; }
        public int IdCondicionPago { get; set; }

        [ForeignKey("IdCondicionPago")]
        public CondicionPago CondicionPago { get; set; }
        public int CantidadArticulo { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
        public int IdEstado { get; set; }

        [ForeignKey("IdEstado")]
        public Estado Estado { get; set; }

        [StringLength(60)]
        public string Comentario { get; set; }
        public List<DetalleFactura> DetalleFactura { get; set; }
    }
}