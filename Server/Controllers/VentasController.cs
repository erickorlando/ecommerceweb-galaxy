using ECommerceWeb.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly IVentaRepository _repository;
        private readonly ILogger<VentasController> _logger;
        private readonly IClienteRepository _clienteRepository;

        public VentasController(IVentaRepository repository, ILogger<VentasController> logger, IClienteRepository clienteRepository)
        {
            _repository = repository;
            _logger = logger;
            _clienteRepository = clienteRepository;
        }
    }
}
