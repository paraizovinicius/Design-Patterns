using System;
namespace Strategy{
    public interface DiscountStrategy{
    decimal ApplyDiscount(decimal amount);

    }
}