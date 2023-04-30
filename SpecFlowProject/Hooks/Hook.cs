using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Hooks
{
    [Binding]
    public class Hooks
    {
        //possible to add next methods
        //[BeforeTestRun]
        //[BeforeFeature]
        //[BeforeScenario]
        //initialize Logger
        //remove old data
        //-create user (set into db)
        //-set prices for food
        
        //[AfterScenario], etc...
        //-delete user
        //-set default food prices
    }
}