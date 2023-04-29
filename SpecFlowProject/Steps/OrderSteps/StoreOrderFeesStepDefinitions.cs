using SpecFlowProject.Client;
using SpecFlowProject.Helpers;
using SpecFlowProject.Models;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject.Steps;

[Binding]
public class StoreOrderFeesStepDefinitions
{
    private readonly FakeApiClient _fakeApiClient = new();
    private readonly OrderFeesCalculator _orderFeesCalculator = new();
    private readonly ScenarioContext _scenarioContext;
    public StoreOrderFeesStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }
    
    [Given(@"I store my order")]
    public void GivenIPlaceOrder(Table table)
    {
        _scenarioContext.Add("orderData",  table.CreateInstance<OrderData>());
    }
    
    [Given(@"I place order and get calculated total price with fees")]
    [When(@"I place order and get calculated total price with fees")]
    public void WhenIGetCalculatedTotalPriceWithFees()
    {
        var orderData = _scenarioContext.Get<OrderData>("orderData").ToDictionary();
        _scenarioContext.Add("totalActual", _fakeApiClient.PlaceOrder(orderData));
    } 
    
    [When(@"I place order with new items and get calculated total price with fees")]
    public void WhenIPlaceOrderWithNewItemsAndGetCalculatedTotalPriceWithFees()
    {
        var orderData = _scenarioContext.Get<OrderData>("orderData").ToDictionary();
        var additionalOrderData = _scenarioContext.Get<OrderData>("additionalOrderData").ToDictionary();
        
        //make api call to receive calculated order data before 19:00 and after
        var placeOrderBeforeDrinksDiscount = _fakeApiClient.PlaceOrder(orderData);
        var placeOrderAfterDrinksDiscount = _fakeApiClient.PlaceOrder(additionalOrderData);
        var totalOrderPrice = placeOrderBeforeDrinksDiscount.orderTotal + placeOrderAfterDrinksDiscount.orderTotal;
        _scenarioContext.Remove("totalActual");
        _scenarioContext.Add("totalActual", (totalOrderPrice, placeOrderBeforeDrinksDiscount.id));
    }
}