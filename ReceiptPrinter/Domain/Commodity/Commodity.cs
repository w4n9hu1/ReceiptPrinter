using ReceiptPrinter.Domain.Enums;
using ReceiptPrinter.Domain.TaxCaculator;

namespace ReceiptPrinter.Domain.Commodity
{
    /// <summary>
    /// 商品
    /// </summary>
    public class Commodity : ITaxItem
    {
        /// <summary>
        /// Id
        /// </summary>
        public int CommodityId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 商品类型
        /// </summary>
        public CommodityType Type { get; set; }
        /// <summary>
        /// 是否进口
        /// </summary>
        public bool IsImported { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
    }
}
