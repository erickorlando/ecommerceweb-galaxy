namespace ECommerceWeb.Entities
{
    public class Venta : EntityBase
    { 
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = default!;
        public float Total { get; set; }
        public DateTime FechaCreacion { get; set; }

        // Esto es una propiedad de navegacion
        public ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();

        public Venta()
        {
            FechaCreacion = DateTime.Now;
        }
    }
}
