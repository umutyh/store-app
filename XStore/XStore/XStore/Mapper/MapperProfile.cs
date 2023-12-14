using AutoMapper;
using XStoreApp.ServiceClient.Models;
using XStoreApp.Models;

namespace XStoreApp.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Products, ProductModel>();
            CreateMap<Products, ProductModel>().ReverseMap();
            CreateMap<ProductForUpdating, ProductModel>();
            CreateMap<ProductForUpdating, ProductModel>().ReverseMap();
            CreateMap<Products, ProductForUpdating>();
            CreateMap<Products, ProductForUpdating>().ReverseMap();
            CreateMap<Products, ProductForCreation>();
            CreateMap<Products, ProductForCreation>().ReverseMap();

            CreateMap<OrderInfoServiceDB, OrderDetailServiceDB>();
            CreateMap<OrderInfoServiceDB, OrderDetailServiceDB>().ReverseMap();
            CreateMap<OrderInfoServiceDB,OrdersModel>();
            CreateMap<OrderInfoServiceDB, OrdersModel>().ReverseMap();

            CreateMap<UsersServiceDB,UserModel>();
            CreateMap<UsersServiceDB, UserModel>().ReverseMap();

            CreateMap<OrderDetailServiceDB, OrdersModel>();                
            CreateMap<OrderDetailServiceDB,OrdersModel>().ReverseMap();
            CreateMap<OrderDetailServiceDB, OrderDetailsModel>();
                //.ForMember(source => source.Price, destination => destination.MapFrom(s => s.Price))
                //.ForMember(source => source.Quantity, destination => destination.MapFrom(s => s.Quantity))
                //.ForMember(source => source.Sku, destination => destination.MapFrom(s => s.Sku));
            CreateMap<OrderDetailServiceDB, OrderDetailsModel>().ReverseMap();
                //.ForMember(source => source.Price, destination => destination.MapFrom(s => s.Price))
                //.ForMember(source => source.Quantity, destination => destination.MapFrom(s => s.Quantity))
                //.ForMember(source => source.Sku, destination => destination.MapFrom(s => s.Sku));

            CreateMap<OrderForUpdatingPriceAndQuantity,OrderForUpdatingPriceAndQuantityModel>();
            CreateMap<OrderForUpdatingPriceAndQuantity, OrderForUpdatingPriceAndQuantityModel>().ReverseMap();
            
        }
    }
}
