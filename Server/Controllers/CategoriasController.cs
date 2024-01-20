using ECommerceWeb.Repositories.Interfaces;
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

        return Ok(await _repository.Listar());

    }
}
