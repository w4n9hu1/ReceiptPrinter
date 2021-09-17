using ReceiptPrinter.Domain.Shopping;
using System.Linq;

namespace ReceiptPrinter.Domain.Receipt
{
    /// <summary>
    /// 收据
    /// </summary>
    public class Receipt
    {
        /// <summary>
        /// 购物明细
        /// </summary>
        public ShoppingCart ShoppingCart { get; set; }

        /// <summary>
        /// 总税额
        /// </summary>
        public decimal Taxes
        {
            get
            {
                return ShoppingCart.ShoppingDetails.Sum(n => (n.Tax * n.Amount));
            }
        }
        /// <summary>
        /// 总金额
        /// </summary>
        public decimal Total
        {
            get
            {
                return ShoppingCart.ShoppingDetails.Sum(n => (n.TaxedPrice * n.Amount));
            }
        }
    }
}
