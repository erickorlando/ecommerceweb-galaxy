namespace ECommerceWeb.Entities;
public class Categoria : EntityBase
{
    public string Nombre { get; set; } = default!;

    public string? Comentarios { get; set; }

    public ICollection<Producto> Productos { get; set; } = default!;
}
