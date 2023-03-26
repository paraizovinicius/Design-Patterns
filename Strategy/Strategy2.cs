using System;
namespace Strategy{
    public class Strategy2 : DiscountStrategy{ //Discount in black Friday
        public decimal ApplyDiscount(decimal amount)
        {
            return amount * 0.2m;
        }
    }

}
