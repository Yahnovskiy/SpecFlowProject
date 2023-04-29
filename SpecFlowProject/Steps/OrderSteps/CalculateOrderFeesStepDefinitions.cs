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


    [When(@"I calculate expected order price with additional items")]
    public void WhenICalculateExpectedOrderPriceWithAdditionalItems()
    {
        var orderData = _scenarioContext.Get<OrderData>("orderData").ToDictionary();
        var additionalOrderData = _scenarioContext.Get<OrderData>("additionalOrderData").ToDictionary();
        
        //call _orderFeesCalculator method to calculate order data before 19:00 and after
        var totalOrderPrice = _orderFeesCalculator.PlaceOrder(orderData).orderTotal +
                              _orderFeesCalculator.PlaceOrder(additionalOrderData).orderTotal;
        
        _scenarioContext.Remove("totalExpected");
        _scenarioContext.Add("totalExpected", totalOrderPrice);    
    }

    [Given(@"Total price with fees should be '(.*)'")]
    [When(@"Total price with fees should be '(.*)'")]
    [Then(@"Total price with fees should be '(.*)'")]
    public void GivenTotalPriceWithFeesShouldBe(double totalExpected)
    {
        var totalActual = _scenarioContext.Get<(double , Guid)>("totalActual").Item1.ToDoubleRound();
        totalActual.Should().Be(totalExpected, "Actual total order price was not equal to expected price");
    }
}