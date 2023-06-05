using AutoMapper;
using WebApp2.DTO_s.ProductDto_s;
using WebApp2.DTO_s.UserDto_s;
using WebApp2.Entities;

namespace WebApp2.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductGetDto>();
        CreateMap<ProductPostDto, Product>();
        CreateMap<AppUser, UserGetDto>().ReverseMap();
    }
}
