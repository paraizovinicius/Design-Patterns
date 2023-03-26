using System;
namespace Strategy{
    public class Strategy1 : DiscountStrategy{ //Normal discount
        public decimal ApplyDiscount(decimal amount)
        {
            return amount * 0.1m;
        }
    }

}
