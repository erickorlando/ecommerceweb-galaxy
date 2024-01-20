using ECommerceWeb.Entities;
using ECommerceWeb.Repositories.Interfaces;

namespace ECommerceWeb.Repositories.Implementaciones;
public class CategoriaRepository : ICategoriaRepository
{
    public async Task<ICollection<Categoria>> Listar()
    {
        var lista = new List<Categoria>();

        lista.Add(new() { Id = 1, Nombre = "Celulares"});
        lista.Add(new() { Id = 2, Nombre = "Televisores"});
        lista.Add(new() { Id = 3, Nombre = "Computadoras"});

        return await Task.FromResult(lista);
    }
}
