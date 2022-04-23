using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailShopApp.Domain.Models;

namespace RetailShopApp.Application.Queries.Bill
{
    public class BillDiscountQuery : IRequest<BillDto>
    {
        public decimal BillAmount { get; set; }
    }
}
