namespace StrategyPattern;

public class PercentageDiscount(decimal percentage) : IDiscountStrategy
{
    private readonly decimal _percentage = percentage;

    public decimal ApplyDiscount(decimal price)
    {
        return price - (price * _percentage / 100);
    }
}
