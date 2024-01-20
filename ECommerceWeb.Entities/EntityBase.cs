namespace ECommerceWeb.Entities;
public class EntityBase
{
    public int Id { get; set; }

    public bool Estado { get; set; }

    public EntityBase()
    {
        Estado = true;
    }
}
