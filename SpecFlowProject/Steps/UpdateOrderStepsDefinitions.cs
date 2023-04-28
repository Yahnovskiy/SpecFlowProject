using SpecFlowProject.Client;
using SpecFlowProject.Helpers;
using SpecFlowProject.Models;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject.Steps;
[Binding]
public class UpdateOrderStepsDefinitions
{
    private readonly FakeApiClient _fakeApiClient = new FakeApiClient();
    private readonly OrderFeesCalculator _orderFeesCalculator = new OrderFeesCalculator();
    private readonly ScenarioContext _scenarioContext;
    public UpdateOrderStepsDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [When(@"I update current order")]
    public void WhenIUpdateCurrentOrder(Table table)
    {
        _scenarioContext.Remove("orderData");
        var orderData = table.CreateInstance<OrderData>();
        _scenarioContext.Add("orderData",  table.CreateInstance<OrderData>());
        
        var actualOrderId = _scenarioContext.Get<(double , Guid)>("totalActual").Item2;
        var totalActual = _fakeApiClient.UpdateOder(orderData.ToDictionary(), actualOrderId);
        
        _scenarioContext.Remove("totalActual");
        _scenarioContext.Add("totalActual", totalActual);
    }

    [When(@"I add food to my order")]
    public void WhenIAddFoodToMyOrder(Table table)
    {
        
    }

    [When(@"I add food to my order when drinks non discounted")]
    public void WhenIAddFoodToMyOrderWhenDrinksNonDiscounted(Table table)
    {
        _scenarioContext.Add("additionalOrderData",  table.CreateInstance<OrderData>());
        
    }
}