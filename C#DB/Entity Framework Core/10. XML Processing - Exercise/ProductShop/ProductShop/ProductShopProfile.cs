using AutoMapper;
using ProductShop.DTOs.Import;
using ProductShop.Models;

namespace ProductShop
{
    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            CreateMap<UsersDTO, User>();
            CreateMap<ProductDTO, Product>();
            CreateMap<CategoryDTO, Category>(); 
            CreateMap<CatProDTO,CategoryProduct>(); 
        }
    }
}
