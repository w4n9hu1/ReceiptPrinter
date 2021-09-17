using ReceiptPrinter.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace ReceiptPrinter.Domain.Commodity.data
{
    /// <summary>
    /// mock data
    /// </summary>
    public class MockCommodityRepository : ICommodityRepository
    {
        public IEnumerable<Commodity> GetAll()
        {
            return new List<Commodity> {
            new Commodity{CommodityId=1,Name="book",IsImported=false,Type=CommodityType.Book, Price=12.49M },
            new Commodity{CommodityId=2,Name="music CD",IsImported=false,Type=CommodityType.Others, Price=14.99M },
            new Commodity{CommodityId=3,Name="chocolate bar",IsImported=false,Type=CommodityType.Food, Price=0.85M },
            new Commodity{CommodityId=4,Name="imported box of chocolates",IsImported=true,Type=CommodityType.Food, Price=10.00M },
            new Commodity{CommodityId=5,Name="imported bottle of perfume",IsImported=true,Type=CommodityType.Others, Price=47.50M },
            new Commodity{CommodityId=6,Name="imported bottle of perfume",IsImported=true,Type=CommodityType.Others, Price=27.99M },
            new Commodity{CommodityId=7,Name="bottle of perfume",IsImported=false,Type=CommodityType.Others, Price=18.99M },
            new Commodity{CommodityId=8,Name="packet of headache pills",IsImported=false,Type=CommodityType.Medical, Price=9.75M },
            new Commodity{CommodityId=9,Name="box of imported chocolates",IsImported=true,Type=CommodityType.Food, Price=11.25M }
            };
        }

        public Commodity Get(int id)
        {
            var stores = GetAll();
            return stores.FirstOrDefault(c => c.CommodityId == id);
        }
    }
}
