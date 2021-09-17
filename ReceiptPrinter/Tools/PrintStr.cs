using ReceiptPrinter.Domain.Receipt;
using ReceiptPrinter.Domain.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptPrinter.Tools
{
    /// <summary>
    /// Console Txt
    /// </summary>
    public static class PrintStr
    {
        /// <summary>
        /// e.g. 1 book at 12.49
        /// </summary>
        /// <param name="bill"></param>
        /// <returns></returns>
        public static string GetStr(this ShoppingCart bill)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in bill.ShoppingDetails)
            {
                sb.Append(item.Amount + " " + item.Commodity.Name + " at " + item.Commodity.Price + "\r\n");
            }
            return sb.ToString();
        }

        /// <summary>
        /// e.g. 1 book : 12.49    Sales Taxes: 1.50   Total: 29.83
        /// </summary>
        /// <param name="receipt"></param>
        /// <returns></returns>
        public static string GetStr(this Receipt receipt)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in receipt.ShoppingCart.ShoppingDetails)
            {
                sb.Append(item.Amount + " " + item.Commodity.Name + " : " + item.TaxedPrice + "\r\n");
            }
            sb.Append("Sales Taxes: " + receipt.Taxes + "\r\n");
            sb.Append("Total: " + receipt.Total);
            return sb.ToString();
        }
    }
}
