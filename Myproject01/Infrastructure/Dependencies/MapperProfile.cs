using AutoMapper;
using Myproject01.Entities;
using Myproject01.Requests;

namespace Myproject01.Infrastructure.Dependencies
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ProductRequest, Product>();
            CreateMap<BrandRequest, Brand>();
        }
    }
}
