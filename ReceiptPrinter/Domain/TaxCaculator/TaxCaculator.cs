using ReceiptPrinter.Domain.Enums;
using System;

namespace ReceiptPrinter.Domain.TaxCaculator
{
    /// <summary>
    /// 商品税计算器
    /// </summary>
    public static class TaxCaculator
    {
        /// <summary>
        /// total tax = Basic sales tax + Import duty
        /// </summary>
        /// <param name="commodity"></param>
        /// <returns></returns>
        public static decimal CalculateTax(this ITaxItem taxItem)
        {
            return FormatTax(taxItem.CalculateBaiscTax() + taxItem.CalculateImportTax());
        }

        /// <summary>
        /// Basic sales tax
        /// </summary>
        /// <param name="taxItem"></param>
        /// <returns></returns>
        private static decimal CalculateBaiscTax(this ITaxItem taxItem)
        {
            if (taxItem.Type == CommodityType.Book
                || taxItem.Type == CommodityType.Food
                || taxItem.Type == CommodityType.Medical)
            {
                return 0;
            }
            return taxItem.Price * 0.1M;
        }

        /// <summary>
        /// Import duty
        /// </summary>
        /// <param name="taxItem"></param>
        /// <returns></returns>
        private static decimal CalculateImportTax(this ITaxItem taxItem)
        {
            if (taxItem.IsImported == false)
            {
                return 0;
            }
            return taxItem.Price * 0.05M;
        }

        /// <summary>
        /// np/100 rounded up to the nearest 0.05
        /// </summary>
        /// <param name="tax"></param>
        /// <returns></returns>
        public static decimal FormatTax(decimal tax)
        {
            var roundOff = 0.05M;
            // C#默认的四舍六入五成双的舍入法
            return Math.Round(tax / roundOff, MidpointRounding.AwayFromZero) * roundOff;
        }
    }
}
