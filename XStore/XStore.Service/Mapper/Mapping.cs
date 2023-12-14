using AutoMapper;
using XStoreApp.ServiceClient.Models;

namespace productStore.Service.Mapper
{
    public class IMapper : Profile
    {
        public IMapper()
        {
            CreateMap<Products, ProductForCreation>();
            CreateMap<Products, ProductForCreation>().ReverseMap();
            CreateMap<Products, ProductForUpdating>();
            CreateMap<Products, ProductForUpdating>().ReverseMap();

            //Login page 
            CreateMap<OrderInfoServiceDB, OrderDetailServiceDB>();
            CreateMap<OrderInfoServiceDB, OrderDetailServiceDB>().ReverseMap();
            CreateMap<OrderDetailServiceDB, OrderForUpdatingPriceAndQuantity>();
            CreateMap<OrderDetailServiceDB, OrderForUpdatingPriceAndQuantity>().ReverseMap();

            //CreateMap<Users, UsersTable>();
            //CreateMap<Users, UsersTable>().ReverseMap();
        }
    }
}
