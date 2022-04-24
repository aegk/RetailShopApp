using RetailShopApp.Domain.Enums;

namespace RetailShopApp.Api.viewModels.Response
{
    public class BillDiscountResponse
    {
        /// <summary>
        /// Gross Price
        /// </summary>
        public decimal GrossPrice { get; set; }
        /// <summary>
        /// Discount Price
        /// </summary>
        public decimal DiscountPrice { get; set; }
        public CustomerType CustomerTypeForDiscount { get; set; }

        /// <summary>
        /// Net Price
        /// </summary>
        public decimal NetPrice { get; set; }
    }
}
