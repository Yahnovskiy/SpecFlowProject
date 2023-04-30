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
        double itemValue = foodItem.Value.ToDouble();

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

    private double CalculatePriceWithFees(double foodPrice)
    {
        //we can use 
        //decimal result = Decimal.Multiply(foodPrice, Decimal.Add(100m, ConstantsDiscount.FoodFees))/100m;

        return foodPrice + (foodPrice * ConstantsDiscount.FoodFees / 100);
    }

    private double CalculateDrinkWithDiscount(double foodPrice)
    {
        return foodPrice - (foodPrice * ConstantsDiscount.DrinksDiscount / 100);
    }

    private bool IsDrinkDiscounted(TimeSpan setTime)
    {
        var currentTime = setTime;
        return currentTime < ConstantsDiscount.DrinksDiscountBeforeTime;
    }
}