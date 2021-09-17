using ReceiptPrinter.Domain.Enums;

namespace ReceiptPrinter.Domain.TaxCaculator
{
    /// <summary>
    /// 商品税计算接口类
    /// </summary>
    public interface ITaxItem
    {
        /// <summary>
        /// 商品类型
        /// </summary>
        public CommodityType Type { get; set; }
        /// <summary>
        /// 是否进口
        /// </summary>
        public bool IsImported { get; set; }
        /// <summary>
        /// 基础价格
        /// </summary>
        public decimal Price { get; set; }
    }
}
