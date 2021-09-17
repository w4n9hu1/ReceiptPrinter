using System.Collections.Generic;

namespace ReceiptPrinter.Domain.Commodity.data
{
    /// <summary>
    /// 商品仓储基类
    /// </summary>
    public interface ICommodityRepository
    {
        IEnumerable<Commodity> GetAll();

        Commodity Get(int id);
    }
}
