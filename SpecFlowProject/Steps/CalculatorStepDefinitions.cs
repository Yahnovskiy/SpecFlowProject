using NUnit.Framework;
using SpecFlowProject.Client;

namespace SpecFlowProject.Steps;

[Binding]
public sealed class CalculatorStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
    private FakeApiClient _fakeApiClient = new FakeApiClient();
    private readonly ScenarioContext _scenarioContext;

    public CalculatorStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 

        //_scenarioContext.Pending();
        Assert.IsTrue(true);
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 

        Assert.IsTrue(true);
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        //TODO: implement act (action) logic

        Assert.IsTrue(true);
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int result)
    {
        //TODO: implement assert (verification) logic

        Assert.IsTrue(true);
    }

    [Given(@"the first (.*)")]
    public void GivenTheFirst(int p0)
    {
        Assert.IsTrue(true);
    }

    [Given(@"Calculate total price")]
    public void GivenCalculateTotalPrice(Table table)
    {
        var fooDictionary = ToDictionary(table);
        _scenarioContext.Add("total", _fakeApiClient.GetOderPriceTotal(fooDictionary));
    }
    
    private Dictionary<string, double> ToDictionary(Table table)
    {
        var dictionary = new Dictionary<string, double>();
        foreach (var row in table.Rows)
        {
            dictionary.Add(row[0], Convert.ToDouble(row[1]));
        }
        return dictionary;
    }

    [Then(@"I should have '(.*)'")]
    public void ThenIShouldHave(string p0)
    {
        var total = _scenarioContext.Get<double>("total");
        Assert.Equals(total, p0);
    }
}