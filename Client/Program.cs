using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Blazored.Toast;
using CurrieTechnologies.Razor.SweetAlert2;
using ECommerceWeb.Client;
using ECommerceWeb.Client.Auth;
using ECommerceWeb.Client.Proxy.Interfaces;
using ECommerceWeb.Client.Proxy.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Esto sale porque la URL base del cliente es la misma que la del servidor
builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazoredSessionStorage();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredToast();

builder.Services.AddSweetAlert2();

// Scoped = Por sesion
builder.Services.AddScoped<ICarritoProxy, CarritoProxy>();

// Habilitamos el contexto de seguridad de Blazor
builder.Services.AddScoped<AuthenticationStateProvider, AuthenticacionService>();
builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();
