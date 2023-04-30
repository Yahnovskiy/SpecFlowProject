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
        var orderData = table.CreateInstance<OrderData>();
        _scenarioContext.Set(table.CreateInstance<OrderData>(), "orderData");
        
        var actualOrderId = _scenarioContext.Get<(decimal , Guid)>("totalActual").Item2;
        var totalActual = _fakeApiClient.UpdateOder(orderData.ToDictionary(), actualOrderId);
        
        _scenarioContext.Set(totalActual, "totalActual");
    }
    
    [When(@"I add food to my order when drinks non discounted")]
    public void WhenIAddFoodToMyOrderWhenDrinksNonDiscounted(Table table)
    {
        _scenarioContext.Set(table.CreateInstance<OrderData>(), "additionalOrderData");
    }
}