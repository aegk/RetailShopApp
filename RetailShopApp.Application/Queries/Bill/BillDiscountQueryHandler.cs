using MediatR;
using RetailShopApp.Domain.Models;
using RetailShopApp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShopApp.Application.Queries.Bill
{
    public class BillDiscountQueryHandler : IRequestHandler<BillDiscountQuery, BillDto>
    {
        public IBillDiscountService _billDiscountService;

        public BillDiscountQueryHandler(IBillDiscountService billDiscountService)
        {
            _billDiscountService = billDiscountService;
        }
        public async Task<BillDto> Handle(BillDiscountQuery request, CancellationToken cancellationToken)
        {
            var bill = await _billDiscountService.GetDiscounts(request.BillAmount, cancellationToken);

            return bill;
        }
    }
}
