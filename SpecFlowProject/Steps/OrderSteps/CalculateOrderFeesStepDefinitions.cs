using FluentAssertions;
using SpecFlowProject.Client;
using SpecFlowProject.Extensions;
using SpecFlowProject.Helpers;
using SpecFlowProject.Models;

namespace SpecFlowProject.Steps;

[Binding]
public class CalculateOrderFeesStepDefinitions
{
    private readonly FakeApiClient _fakeApiClient = new();
    private readonly OrderFeesCalculator _orderFeesCalculator = new();
    private readonly ScenarioContext _scenarioContext;
    public CalculateOrderFeesStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given(@"I calculate expected order price")]
    [When(@"I calculate expected order price")]
    public void WhenICalculateExpectedOrderPrice()
    {
        var orderData = _scenarioContext.Get<OrderData>("orderData").ToDictionary();
        var calculateExpectedOrderData = _orderFeesCalculator.PlaceOrder(orderData).orderTotal.ToDecimalRound();
        _scenarioContext.Set(calculateExpectedOrderData, "totalExpected");
    }
    
    [Given(@"I check calculated total price with fees")]
    [Then(@"I check calculated total price with fees")]

    public void ThenICheckCalculatedTotalPriceWithFees()
    {
        var totalActual = _scenarioContext.Get<(decimal , Guid)>("totalActual").Item1.ToDecimalRound();
        var totalExpected = _scenarioContext.Get<decimal>("totalExpected").ToDecimalRound();

        totalActual.Should().Be(totalExpected, "Actual total order price was not equal to expected price");
    }


    [When(@"I calculate expected order price with additional items")]
    public void WhenICalculateExpectedOrderPriceWithAdditionalItems()
    {
        var orderData = _scenarioContext.Get<OrderData>("orderData").ToDictionary();
        var additionalOrderData = _scenarioContext.Get<OrderData>("additionalOrderData").ToDictionary();
        
        //call _orderFeesCalculator method to calculate order data before 19:00 and after
        var totalOrderPrice = _orderFeesCalculator.PlaceOrder(orderData).orderTotal +
                              _orderFeesCalculator.PlaceOrder(additionalOrderData).orderTotal;
        
        _scenarioContext.Set(totalOrderPrice, "totalExpected");    
    }

    [Given(@"Total price with fees should be '(.*)'")]
    [When(@"Total price with fees should be '(.*)'")]
    [Then(@"Total price with fees should be '(.*)'")]
    public void GivenTotalPriceWithFeesShouldBe(decimal totalExpected)
    {
        var totalActual = _scenarioContext.Get<(decimal , Guid)>("totalActual").Item1.ToDecimalRound();
        totalActual.Should().Be(totalExpected, "Actual total order price was not equal to expected price");
    }
}