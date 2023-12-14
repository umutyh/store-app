using AutoMapper;
using store.Database.Models;
using store.Service.Models;

namespace store.Service.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Products, ProductForCreation>();
            CreateMap<Products, ProductForUpdating>();


            CreateMap<Products, Table1>();
            CreateMap<Products, Table1>().ReverseMap();


            CreateMap<ProductForCreation, Table1>();


            CreateMap<Table1, ProductForUpdating>();
            CreateMap<Table1, ProductForUpdating>().ReverseMap();

            //Login page 
            CreateMap<OrderInfoServiceDB, OrderDetailServiceDB>();
            CreateMap<OrderInfoServiceDB, OrderDetailServiceDB>().ReverseMap();

            CreateMap<UsersServiceDB,UsersTable>();
            CreateMap<UsersServiceDB, UsersTable>().ReverseMap();

            CreateMap<OrderDetailServiceDB, OrderDetailCreation>();
            CreateMap<OrderDetailServiceDB, OrderDetailCreation>().ReverseMap();


            CreateMap<OrderDetails, OrderDetailCreation>();
            CreateMap<OrderDetails, OrderDetailCreation>().ReverseMap();


            CreateMap<OrderDetailServiceDB, OrderDetails>();
            CreateMap<OrderDetailServiceDB, OrderDetails>().ReverseMap();


            CreateMap<Orders, OrderInfoCreation>();
            CreateMap<Orders, OrderInfoCreation>().ReverseMap();

            CreateMap<Orders, OrderInfoServiceDB>();
            CreateMap<Orders, OrderInfoServiceDB>().ReverseMap();

            CreateMap<OrderInfoServiceDB, OrderInfoCreation>();
            CreateMap<OrderInfoServiceDB, OrderInfoCreation>().ReverseMap();

            CreateMap<OrderDetailsCombined, OrdersJoinedTable>();
            CreateMap<OrderDetailsCombined, OrdersJoinedTable>().ReverseMap();

            CreateMap<OrderDetails, OrderForUpdatingPriceAndQuantity>();
            CreateMap<OrderDetails, OrderForUpdatingPriceAndQuantity>().ReverseMap();
            CreateMap<OrderDetailServiceDB, OrderForUpdatingPriceAndQuantity>();
            CreateMap<OrderDetailServiceDB, OrderForUpdatingPriceAndQuantity>().ReverseMap();
        }
    }
}
