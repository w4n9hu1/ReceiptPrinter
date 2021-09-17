using ReceiptPrinter.Domain.Commodity;
using ReceiptPrinter.Domain.Enums;
using ReceiptPrinter.Domain.Receipt;
using ReceiptPrinter.Domain.Shopping;
using Xunit;

namespace ReceiptPrinterTest
{
    public class ReceiptPrinterTest
    {
        [Fact]
        public void FoodTest()
        {
            ShoppingDetail shoppingDetail = new ShoppingDetail { Commodity = new Commodity { Name = "food", IsImported = false, Type = CommodityType.Food, Price = 17.6M } };
            var tax = 0;
            Assert.Equal(tax, shoppingDetail.Tax);
        }

        [Fact]
        public void OtherTypeTest()
        {
            ShoppingDetail shoppingDetail = new ShoppingDetail { Commodity = new Commodity { Name = "cd", IsImported = false, Type = CommodityType.Others, Price = 17.6M } };
            var tax = 1.75M;
            Assert.Equal(tax, shoppingDetail.Tax);
        }

        [Fact]
        public void ImportFoodTest()
        {
            ShoppingDetail shoppingDetail = new ShoppingDetail { Commodity = new Commodity { Name = "imported food", IsImported = true, Type = CommodityType.Food, Price = 17.6M } };
            var tax = 0.90M;
            Assert.Equal(tax, shoppingDetail.Tax);
        }

        [Fact]
        public void ImportOtherTypeTest()
        {
            ShoppingDetail shoppingDetail = new ShoppingDetail { Commodity = new Commodity { Name = "imported cd", IsImported = true, Type = CommodityType.Others, Price = 17.6M } };
            var tax = 2.65M;
            Assert.Equal(tax, shoppingDetail.Tax);
        }

        [Fact]
        public void ReceiptTest()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            Receipt receipt = new Receipt { ShoppingCart = shoppingCart };
            shoppingCart.ShoppingDetails.Add(new ShoppingDetail
            {
                Commodity = new Commodity { Name = "chocolates", Price = 10.00M, IsImported = true, Type = CommodityType.Food },
                Amount = 1
            });
            shoppingCart.ShoppingDetails.Add(new ShoppingDetail
            {
                Commodity = new Commodity { Name = "perfume", Price = 47.50M, IsImported = true, Type = CommodityType.Others },
                Amount = 1
            });
            var salesTax = 7.65M;
            var total = 65.15M;
            Assert.Equal(salesTax, receipt.Taxes);
            Assert.Equal(total, receipt.Total);
        }
    }
}
