using SpecFlowProject.Client.Constants;
using SpecFlowProject.Extensions;

namespace SpecFlowProject.Helpers;

public class OrderFeesCalculator
{
    //!!!!!!!!!!!!!!!!!!!!
    //in case with real api we need to implement method
    //which calculate total order price with fees and discounts
    //in this case I utilized (unfortunately) code duplication
    //possible hard code expected result total order values into scenario examples
    
    private readonly TimeSpan _timeSpan = DateTime.UtcNow.TimeOfDay;

    public (decimal orderTotal, Guid id) PlaceOrder(Dictionary<string, object> orderedFood)
    {
        var time = orderedFood["Time"].ToTimeSpan();
        var setTime = time != default ? time : _timeSpan;

        var totalPriceList = orderedFood.Select(foodItem => CalculateFoodPrice(foodItem, setTime)).ToList();
        return (totalPriceList.Sum(), Guid.NewGuid());
    }

    private decimal CalculateFoodPrice(KeyValuePair<string, object> foodItem, TimeSpan setTime)
    {
        decimal foodPrice = 0;
        decimal itemValue = foodItem.Value.ToDecimal();

        switch (foodItem.Key)
        {
            case string key when key.Equals(FoodType.Drinks.ToString()):
                var drinksPriceSum = itemValue * ConstantsFoodCosts.Drinks;
                foodPrice = IsDrinkDiscounted(setTime) ? CalculateDrinkWithDiscount(drinksPriceSum) : drinksPriceSum;
                break;
            case string key when key.Equals(FoodType.Mains.ToString()):
                foodPrice = itemValue * ConstantsFoodCosts.Mains;
                break;
            case string key when key.Equals(FoodType.Starters.ToString()):
                foodPrice = itemValue * ConstantsFoodCosts.Starters;
                break;
        }

        return CalculatePriceWithFees(foodPrice);
    }

    private decimal CalculatePriceWithFees(decimal foodPrice)
    {
        //we can use 
        //decimal result = Decimal.Multiply(foodPrice, Decimal.Add(100m, ConstantsDiscount.FoodFees))/100m;

        return foodPrice + (foodPrice * ConstantsDiscount.FoodFees / 100);
    }

    private decimal CalculateDrinkWithDiscount(decimal foodPrice)
    {
        return foodPrice - (foodPrice * ConstantsDiscount.DrinksDiscount / 100);
    }

    private bool IsDrinkDiscounted(TimeSpan setTime)
    {
        var currentTime = setTime;
        return currentTime < ConstantsDiscount.DrinksDiscountBeforeTime;
    }
}