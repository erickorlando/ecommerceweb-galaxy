using ECommerceWeb.Entities;

namespace ECommerceWeb.Repositories.Interfaces;
public interface ICategoriaRepository
{
    Task<ICollection<Categoria>> Listar();
}
