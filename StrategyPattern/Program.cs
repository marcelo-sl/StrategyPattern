namespace StrategyPattern;

internal class Program
{
    static void Main(string[] args)
    {
        const decimal originalPrice = 100.0m;
        const decimal percentegeDiscount = 10m;
        const decimal fixedDiscountValue = 15m;

        Console.WriteLine($"Original price: {originalPrice}");

        // 10% off
        IDiscountStrategy percentageDiscount = new PercentageDiscount(percentegeDiscount); 
        var cart1 = new ShoppingCart(percentageDiscount);
        Console.WriteLine($"Final price with {percentegeDiscount} percentage discount: {cart1.GetFinalPrice(originalPrice)}");

        // Fixed 15.0m off
        IDiscountStrategy fixedDiscount = new FixedAmountDiscount(fixedDiscountValue); 
        var cart2 = new ShoppingCart(fixedDiscount);
        Console.WriteLine($"Final price with {fixedDiscountValue} fixed discount: {cart2.GetFinalPrice(originalPrice)}");

        // VIPs 20% off
        IDiscountStrategy vipDiscount = new VIPDiscount(); 
        var cart3 = new ShoppingCart(vipDiscount);
        Console.WriteLine($"Final price for VIP customer: {cart3.GetFinalPrice(originalPrice)}");
    }
}