using RetailShopApp.Domain.Enums;
using RetailShopApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShopApp.Domain.Services
{
    public class BillDiscountService : IBillDiscountService
    {
        public async Task<BillDto> GetDiscounts(decimal amount, CancellationToken cancellationToken = default)
        {
            BillDto result = new BillDto();
            var totalDiscount = new decimal();

            result.GrossPrice = amount;
            if ("userIsEmployee" == "true")
            {
                result.CustomerTypeForDiscount = CustomerType.Employee;
                totalDiscount = (amount * 70) / 100;
            }
            else if ("userIsAffialete" == "true")
            {
                result.CustomerTypeForDiscount = CustomerType.Affiliate;
                totalDiscount = (amount * 90) / 100;
            }
            else if ("userIsOldCustomer" == "true")
            {
                result.CustomerTypeForDiscount = CustomerType.OldCustomer;
                totalDiscount = (amount * 95) / 100;
            }

            var loopCountForHundred = (amount - amount % 100) / 100 ;

            var totalDiscountForEveryHundred = loopCountForHundred * 5;

            totalDiscount = totalDiscount + totalDiscountForEveryHundred;

            result.DiscountPrice = totalDiscount;
            result.NetPrice = amount - totalDiscount;

            return result;
        }
    }
}
