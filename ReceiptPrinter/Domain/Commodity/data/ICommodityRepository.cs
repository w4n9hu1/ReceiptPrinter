using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
