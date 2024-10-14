namespace StrategyPattern;

public class VIPDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal price)
    {
        // VIP customers get a 20% discount
        return price - (price * 0.2m);
    }
}
