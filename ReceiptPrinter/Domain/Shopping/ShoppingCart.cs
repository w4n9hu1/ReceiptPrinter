using ReceiptPrinter.Domain.Commodity;
using System.Collections.Generic;

namespace ReceiptPrinter.Domain.Shopping
{
    /// <summary>
    /// 购物车
    /// </summary>
    public class ShoppingCart
    {
        /// <summary>
        /// 购物明细
        /// </summary>
        public List<ShoppingDetail> ShoppingDetails { get; set; } = new List<ShoppingDetail>();
    }
}
