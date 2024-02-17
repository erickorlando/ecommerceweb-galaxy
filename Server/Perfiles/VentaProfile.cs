using AutoMapper;
using ECommerceWeb.Entities;
using ECommerceWeb.Shared.Request;

namespace ECommerceWeb.Server.Perfiles
{
    public class VentaProfile : Profile
    {
        public VentaProfile()
        {
            CreateMap<VentaDto, Venta>();
            CreateMap<VentaDetalleDto, VentaDetalle>();
        }
    }
}
