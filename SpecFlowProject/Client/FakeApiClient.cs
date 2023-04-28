using SpecFlowProject.Client.Constants;

namespace SpecFlowProject.Client;

public class FakeApiClient
{
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