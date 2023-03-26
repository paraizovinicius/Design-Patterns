using System;
namespace Strategy{
    public class StrategyCalculation
    {
        private readonly DiscountStrategy _discountStrategy; //Declarates a new object

        public StrategyCalculation(DiscountStrategy discountStrategy) //Constructor of new object
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateTotal(decimal amount)
        {
            var discount = _discountStrategy.ApplyDiscount(amount);
            return amount - discount; //now we have the new price for sale
        }
    }
}

