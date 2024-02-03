namespace ECommerceWeb.Shared.Response;

public class LoginDtoResponse
{
    public string Token { get; set; } = default!;
    public string NombreCompleto { get; set; } = default!;
    public List<string> Roles { get; set; } = default!;

    public string? MensajeError { get; set; }
    public bool Exito { get; set; }
}