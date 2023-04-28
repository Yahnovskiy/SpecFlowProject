using FluentAssertions;
using SpecFlowProject.Client;
using SpecFlowProject.Extensions;
using SpecFlowProject.Helpers;
using SpecFlowProject.Models;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject.Steps;

[Binding]
public class CalculateOrderFeesStepDefinitions
{
    private readonly FakeApiClient _fakeApiClient = new FakeApiClient();
    private readonly OrderFeesCalculator _orderFeesCalculator = new OrderFeesCalculator();
    private readonly ScenarioContext _scenarioContext;
    public CalculateOrderFeesStepDefinitions(ScenarioContext scenarioContext)
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
    
    [Given(@"I calculate expected order price")]
    [When(@"I calculate expected order price")]
    public void WhenICalculateExpectedOrderPrice()
    {
        var orderData = _scenarioContext.Get<OrderData>("orderData").ToDictionary();
        var calculateExpectedOrderData = _orderFeesCalculator.PlaceOrder(orderData).orderTotal.ToDoubleRound();
        _scenarioContext.Remove("totalExpected");
        _scenarioContext.Add("totalExpected", calculateExpectedOrderData);
    }
    
    [Given(@"I check calculated total price with fees")]
    [Then(@"I check calculated total price with fees")]

    public void ThenICheckCalculatedTotalPriceWithFees()
    {
        var totalActual = _scenarioContext.Get<(double , Guid)>("totalActual").Item1.ToDoubleRound();
        var totalExpected = _scenarioContext.Get<double>("totalExpected").ToDoubleRound();

        totalActual.Should().Be(totalExpected, "Actual total order price was not equal to expected price");
    }
    
    [When(@"I place order with new items and get calculated total price with fees")]
    public void WhenIPlaceOrderWithNewItemsAndGetCalculatedTotalPriceWithFees()
    {
        var orderData = _scenarioContext.Get<OrderData>("orderData").ToDictionary();
        var additionalOrderData = _scenarioContext.Get<OrderData>("additionalOrderData").ToDictionary();
        
        var totalOrderPrice = _fakeApiClient.PlaceOrder(orderData).orderTotal +
                              _fakeApiClient.PlaceOrder(additionalOrderData).orderTotal;
        _scenarioContext.Add("allTotalActual", totalOrderPrice);
    }
}