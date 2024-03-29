﻿using ECommerceWeb.Server.Services;
using ECommerceWeb.Shared.Request;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceWeb.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly IUserService _service;

    public UsuariosController(IUserService service)
    {
        _service = service;
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginDtoRequest request)
    {
        var response = await _service.LoginAsync(request);

        return Ok(response);
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromBody] RegistrarUsuarioDto request)
    {
        var response = await _service.RegisterAsync(request);

        return Ok(response);
    }
}