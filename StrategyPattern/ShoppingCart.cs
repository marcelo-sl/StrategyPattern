namespace StrategyPattern;

public class ShoppingCart(IDiscountStrategy discountStrategy)
{
    private readonly IDiscountStrategy _discountStrategy = discountStrategy;

    public decimal GetFinalPrice(decimal price)
    {
        return _discountStrategy.ApplyDiscount(price);
    }
}