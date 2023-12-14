using AutoMapper;
using store.Service.Models;

namespace store.API
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Products, ProductForCreation>();
            CreateMap<Products, ProductForUpdating>();
            CreateMap<Products, ProductForCreation>().ReverseMap();
            CreateMap<Products, ProductForUpdating>().ReverseMap();
        }
    }
}
