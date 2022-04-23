using RetailShopApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShopApp.Domain.Services
{
    public interface IBillDiscountService
    {

        Task<BillDto> GetDiscounts(decimal bill, CancellationToken cancellationToken = default);
    }
}
