using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prjMaestroDetalle.Models
{
    public class DetalleFactura
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int Cantidad { get; set; }
        public double ITBIs { get; set; }
        public double Valor { get; set; }
        public int IdArticulo { get; set; }
        
        [ForeignKey("IdArticulo")]
        public Articulo Articulo { get; set; }
        public int IdFactura { get; set; }
        
        [ForeignKey("IdFactura")]
        public Factura Factura { get; set; }

        public DetalleFactura(int Cantidad, int IdArticulo)
        {
            this.Cantidad = Cantidad;
            this.IdArticulo = IdArticulo;
        }

        public DetalleFactura(int Cantidad, double ITBIs,  double Valor, int IdArticulo, int IdFactura){
            this.Cantidad = Cantidad;
            this.ITBIs = ITBIs;
            this.Valor = Valor;
            this.IdArticulo = IdArticulo;
            this.IdFactura = IdFactura;
        }

        public DetalleFactura()
        {
            
        }
    }
}