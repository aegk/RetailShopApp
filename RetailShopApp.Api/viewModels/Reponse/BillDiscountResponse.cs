using RetailShopApp.Domain.Enums;

namespace RetailShopApp.Api.viewModels.Response
{
    public class BillDiscountResponse
    {
        public decimal GrossPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public DiscountType discountType { get; set; }

        public decimal NetPrice { get; set; }
    }
}
