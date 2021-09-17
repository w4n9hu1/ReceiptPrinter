namespace ReceiptPrinter.Domain.Enums
{
    /// <summary>
    /// commodity type
    /// Basic sales tax is applicable at a rate of 10% on all goods, except books, food, and medical products that are exempt. 
    /// </summary>
    public enum CommodityType
    {
        Book = 1,
        Food = 2,
        Medical = 3,
        Others = 4
    }
}
