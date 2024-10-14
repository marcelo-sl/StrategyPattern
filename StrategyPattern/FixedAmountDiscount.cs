namespace StrategyPattern;

public class FixedAmountDiscount(decimal fixedDiscount) : IDiscountStrategy
{
    private readonly decimal _fixedDiscount = fixedDiscount;

    public decimal ApplyDiscount(decimal price)
    {
        return price - _fixedDiscount;
    }
}
