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
    
    [Given(@"I place order")]
    public void GivenIPlaceOrder(Table table)
    {
        _scenarioContext.Add("orderData",  table.CreateInstance<OrderData>());
    }

    [When(@"I get calculated total price with fees")]
    public void WhenIGetCalculatedTotalPriceWithFees()
    {
        var orderData = _scenarioContext.Get<OrderData>("orderData").ToDictionary();
        _scenarioContext.Add("totalActual", _fakeApiClient.GetOderPriceTotal(orderData));
    }
    
    [When(@"I calculate expected order price")]
    public void WhenICalculateExpectedOrderPrice()
    {
        var orderData = _scenarioContext.Get<OrderData>("orderData").ToDictionary();
        var calculateExpectedOrderData = _orderFeesCalculator.GetOderPriceTotal(orderData).ToDoubleRound();
        _scenarioContext.Add("totalExpected", calculateExpectedOrderData);
    }
    
    [Then(@"I check calculated total price with fees")]
    public void ThenICheckCalculatedTotalPriceWithFees()
    {
        var totalActual = _scenarioContext.Get<double>("totalActual").ToDoubleRound();
        var totalExpected = _scenarioContext.Get<double>("totalExpected").ToDoubleRound();

        totalActual.Should().Be(totalExpected, "Actual total order price was not equal to expected price");
    }
}