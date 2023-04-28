using SpecFlowProject.Client.Constants;

namespace SpecFlowProject.Client;

public class FakeApiClient
{
    public double GetOderPriceTotal(Dictionary<string, double> orderedFood)
    {
        var totalPriceList = orderedFood.Select(foodItem => CalculateFoodPrice(foodItem)).ToList();
        return totalPriceList.Sum();
    }

    private double CalculateFoodPrice(KeyValuePair<string, double> foodItem)
    {
        double foodPrice;
        
        ValidateFoodItemPrice(foodItem);
        if (foodItem.Key.Equals(FoodType.Drinks.ToString()) && IsDrinkDiscounted())
            foodPrice = CalculateDrinkWithDiscount(foodItem.Value);
        else
            foodPrice = foodItem.Value;
        
        return CalculatePriceWithFees(foodPrice);
    }

    private void ValidateFoodItemPrice(KeyValuePair<string, double> foodItem)
    {
        if (foodItem.Value == 0)
            throw new Exception($"{foodItem.Key} has incorrect price: {foodItem.Value}");
    }

    private double CalculatePriceWithFees(double foodPrice)
    {
        return foodPrice + (foodPrice * ConstantsDiscount.FoodFees) / 100;
    }

    private double CalculateDrinkWithDiscount(double foodPrice)
    {
        return foodPrice - ((foodPrice * ConstantsDiscount.DrinksDiscount) / 100);
    }

    private bool IsDrinkDiscounted()
    {
        var currentTime = DateTime.UtcNow.TimeOfDay;
        return currentTime < ConstantsDiscount.DrinksDiscountBeforeTime;
    }
}