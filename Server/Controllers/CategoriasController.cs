using ECommerceWeb.Entities;
using ECommerceWeb.Repositories.Interfaces;
using ECommerceWeb.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceWeb.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriasController : ControllerBase
{
    private readonly ICategoriaRepository _repository;
    public CategoriasController(ICategoriaRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {

        return Ok(await _repository.ListAsync());

    }

    [HttpPost]
    [Authorize]

    public async Task<IActionResult> Post(CategoriaDto request)
    {

        var categoria = new Categoria
        {
            Nombre = request.Nombre,
            Comentarios = request.Comentarios
        };
        await _repository.AddAsync(categoria);
        return Ok();
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var categoria = await _repository.FindAsync(id);
        if (categoria is null)
        {
            return NotFound();
        }
        return Ok(categoria);
    }

    [HttpPut("{id:int}")]
    [Authorize]
    public async Task<IActionResult> Put(int id, CategoriaDto request)
    {
        var categoria = await _repository.FindAsync(id);
        if (categoria is null)
        {
            return NotFound();
        }
        categoria.Nombre = request.Nombre;
        categoria.Comentarios = request.Comentarios;
        await _repository.UpdateAsync();
        return Ok();
    }

    [HttpDelete("{id:int}")]
    [Authorize]

    public async Task<IActionResult> Delete(int id)
    {
        await _repository.DeleteAsync(id);

        return Ok();
    }
}
