using ReceiptPrinter.Domain.TaxCaculator;

namespace ReceiptPrinter.Domain.Commodity
{

    /// <summary>
    /// 购买明细
    /// </summary>
    public class ShoppingDetail
    {
        /// <summary>
        /// 商品
        /// </summary>
        public Commodity Commodity { get; set; }
        /// <summary>
        /// 税
        /// </summary>
        public decimal Tax
        {
            get
            {
                return Commodity.CalculateTax();
            }
        }
        /// <summary>
        /// 含税价格
        /// </summary>
        public decimal TaxedPrice
        {
            get
            {
                return Commodity.Price + Tax;
            }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public int Amount { get; set; }
    }
}
