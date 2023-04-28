using SpecFlowProject.Client.Constants;
using SpecFlowProject.Extensions;

namespace SpecFlowProject.Client;

public class FakeApiClient
{
    private readonly TimeSpan _timeSpan = DateTime.UtcNow.TimeOfDay;
    public (double orderTotal, Guid id) PlaceOrder(Dictionary<string, object> orderedFood)
    {
        var time = orderedFood["Time"].ToTimeSpan();
        var setTime = time != default ? time : _timeSpan;
        
        var totalPriceList = orderedFood.Select(foodItem => CalculateFoodPrice(foodItem, setTime)).ToList();
        return (totalPriceList.Sum(), Guid.NewGuid());
    }

    public (double orderTotal, Guid id) UpdateOder(Dictionary<string, object> orderedFood, Guid orderId)
    {
        //in real life inside this method should be implemented update order by ID
        return PlaceOrder(orderedFood);
    }

    private double CalculateFoodPrice(KeyValuePair<string, object> foodItem, TimeSpan setTime)
    {
        double foodPrice = 0;
        if (foodItem.Key.Equals(FoodType.Drinks.ToString()))
        {
            var drinksPriceSum = foodItem.Value.ToDouble() * ConstantsFoodCosts.Drinks;
            foodPrice = IsDrinkDiscounted(setTime) ? CalculateDrinkWithDiscount(drinksPriceSum) : drinksPriceSum; 
        }
        else if(foodItem.Key.Equals(FoodType.Mains.ToString()))
            foodPrice = foodItem.Value.ToDouble()*ConstantsFoodCosts.Mains;
        else if(foodItem.Key.Equals(FoodType.Starters.ToString()))
            foodPrice = foodItem.Value.ToDouble()*ConstantsFoodCosts.Starters;
        
        var qwe = CalculatePriceWithFees(foodPrice);
        return CalculatePriceWithFees(foodPrice);
    }
    
    private double CalculatePriceWithFees(double foodPrice)
    {
        return foodPrice != 0 ? foodPrice + (foodPrice * ConstantsDiscount.FoodFees) / 100 : 0;
    }
    
    private double CalculateDrinkWithDiscount(double foodPrice)
    {
        return foodPrice != 0 ? foodPrice - ((foodPrice * ConstantsDiscount.DrinksDiscount) / 100) : 0;
    }

    private bool IsDrinkDiscounted(TimeSpan setTime)
    {
        var currentTime = setTime;
        return currentTime < ConstantsDiscount.DrinksDiscountBeforeTime;
    }
}