using ReceiptPrinter.Domain.Commodity;
using ReceiptPrinter.Domain.Commodity.data;
using ReceiptPrinter.Domain.Receipt;
using ReceiptPrinter.Domain.Shopping;
using ReceiptPrinter.Tools;
using System;

namespace ReceiptPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            // commodity store
            var store = new CommodityStore(new MockCommodityRepository());
            var shoppingCart = new ShoppingCart();
            var receipt = new Receipt { ShoppingCart = shoppingCart };

            // mock bill
            var buyarr = new[] { 1, 2, 3 };
            foreach (var id in buyarr)
            {
                shoppingCart.ShoppingDetails.Add(new ShoppingDetail { Commodity = store.Get(id), Amount = 1 });
            }

            // InPut
            Console.WriteLine(shoppingCart.GetStr());
            // OutPut
            Console.WriteLine(receipt.GetStr());

            Console.ReadKey();
        }
    }
}
