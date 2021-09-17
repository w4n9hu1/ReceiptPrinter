using ReceiptPrinter.Domain.Commodity.data;
using System.Collections.Generic;

namespace ReceiptPrinter.Domain.Commodity
{
    /// <summary>
    /// 商品库存服务
    /// </summary>
    public class CommodityStore
    {
        private readonly ICommodityRepository _commodityRepository;

        public CommodityStore(ICommodityRepository commodityReosity)
        {
            _commodityRepository = commodityReosity;
        }

        /// <summary>
        /// 获取所有商品
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Commodity> GetCommodities()
        {
            return _commodityRepository.GetAll();
        }

        /// <summary>
        /// 按ID获取商品
        /// </summary>
        /// <returns></returns>
        public Commodity Get(int id)
        {
            return _commodityRepository.Get(id);
        }
    }
}
