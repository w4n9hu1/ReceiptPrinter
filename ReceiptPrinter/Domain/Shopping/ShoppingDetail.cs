using ReceiptPrinter.Domain.TaxCaculator;

namespace ReceiptPrinter.Domain.Commodity
{

    /// <summary>
    /// 购买明细
    /// </summary>
    public class ShoppingDetail
    {
        public Commodity Commodity { get; set; }
        public decimal Tax
        {
            get
            {
                return Commodity.CalculateTax();
            }
        }
        public decimal TaxedPrice
        {
            get
            {
                return Commodity.Price + Tax;
            }
        }
        public int Amount { get; set; }
    }
}
