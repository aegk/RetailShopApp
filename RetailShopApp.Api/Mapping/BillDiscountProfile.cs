using AutoMapper;
using RetailShopApp.Api.viewModels.Request;
using RetailShopApp.Api.viewModels.Response;
using RetailShopApp.Application.Queries.Bill;
using RetailShopApp.Domain.Models;

namespace RetailShopApp.Api.Mapping
{
    public class BillDiscountProfile : Profile
    {
        public BillDiscountProfile()
        {
                CreateMap<BillDiscountRequest,BillDiscountQuery>();
            CreateMap<BillDto, BillDiscountResponse>();
        }
    }
}
