using SpecFlowProject.Client.Constants;

namespace SpecFlowProject.Helpers;

public class OrderFeesCalculator
{
    //!!!!!!!!!!!!!!!!!!!!
    //in case with real api we need to implement method
    //which calculate total order price with fees and discounts
    //in this case I utilized (unfortunately) code duplication
    //possible hard code expected result total order values into scenario examples
    
    private readonly TimeSpan _timeSpan = DateTime.UtcNow.TimeOfDay;
    public double GetOderPriceTotal(Dictionary<string, int> orderedFood, TimeSpan setTime = default)
    {
        setTime = setTime == default ? _timeSpan : setTime;
        
        var totalPriceList = orderedFood.Select(foodItem => CalculateFoodPrice(foodItem, setTime)).ToList();
        return totalPriceList.Sum();
    }

    private double CalculateFoodPrice(KeyValuePair<string, int> foodItem, TimeSpan setTime)
    {
        double foodPrice;
        
        if (foodItem.Key.Equals(FoodType.Drinks.ToString()) && IsDrinkDiscounted(setTime))
            foodPrice = CalculateDrinkWithDiscount(foodItem.Value);
        else
            foodPrice = foodItem.Value;
        
        return CalculatePriceWithFees(foodPrice);
    }
    
    private double CalculatePriceWithFees(double foodPrice)
    {
        return foodPrice + (foodPrice * ConstantsDiscount.FoodFees) / 100;
    }
    
    private double CalculateDrinkWithDiscount(double foodPrice)
    {
        return foodPrice - ((foodPrice * ConstantsDiscount.DrinksDiscount) / 100);
    }

    private bool IsDrinkDiscounted(TimeSpan setTime)
    {
        var currentTime = setTime;
        return currentTime < ConstantsDiscount.DrinksDiscountBeforeTime;
    }
}