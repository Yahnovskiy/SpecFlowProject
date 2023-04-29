﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowProject.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Order calculation")]
    public partial class OrderCalculationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "OrderCalculation.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Order calculation", "\tIn the first three scenarios implemented calculation expected order values via a" +
                    "utomation code\n\tIn the next three scenarios implemented hardcoded expected order" +
                    " value with fees", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Place and calculate order")]
        [NUnit.Framework.TestCaseAttribute("4", "4", "4", "Now", null)]
        public virtual void PlaceAndCalculateOrder(string drinks, string starters, string mains, string time, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Drinks", drinks);
            argumentsOfScenario.Add("Starters", starters);
            argumentsOfScenario.Add("Mains", mains);
            argumentsOfScenario.Add("Time", time);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Place and calculate order", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Drinks",
                            "Starters",
                            "Mains",
                            "Time"});
                table1.AddRow(new string[] {
                            string.Format("{0}", drinks),
                            string.Format("{0}", starters),
                            string.Format("{0}", mains),
                            string.Format("{0}", time)});
#line 7
 testRunner.Given("I store my order", ((string)(null)), table1, "Given ");
#line hidden
#line 10
 testRunner.When("I place order and get calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.And("I calculate expected order price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.Then("I check calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Place, update and calculate order with time")]
        [NUnit.Framework.TestCaseAttribute("2", "1", "2", "18:00", "2", "2", "20:00", null)]
        public virtual void PlaceUpdateAndCalculateOrderWithTime(string drinksBefore, string startersBefore, string mainsBefore, string timeBefore, string drinksAfter, string mainsAfter, string timeAfter, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("DrinksBefore", drinksBefore);
            argumentsOfScenario.Add("StartersBefore", startersBefore);
            argumentsOfScenario.Add("MainsBefore", mainsBefore);
            argumentsOfScenario.Add("TimeBefore", timeBefore);
            argumentsOfScenario.Add("DrinksAfter", drinksAfter);
            argumentsOfScenario.Add("MainsAfter", mainsAfter);
            argumentsOfScenario.Add("TimeAfter", timeAfter);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Place, update and calculate order with time", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 17
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Drinks",
                            "Starters",
                            "Mains",
                            "Time"});
                table2.AddRow(new string[] {
                            string.Format("{0}", drinksBefore),
                            string.Format("{0}", startersBefore),
                            string.Format("{0}", mainsBefore),
                            string.Format("{0}", timeBefore)});
#line 18
 testRunner.Given("I store my order", ((string)(null)), table2, "Given ");
#line hidden
#line 21
 testRunner.And("I place order and get calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And("I calculate expected order price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And("I check calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Drinks",
                            "Starters",
                            "Mains",
                            "Time"});
                table3.AddRow(new string[] {
                            string.Format("{0}", drinksAfter),
                            "<StartersAfter>",
                            string.Format("{0}", mainsAfter),
                            string.Format("{0}", timeAfter)});
#line 24
 testRunner.When("I add food to my order when drinks non discounted", ((string)(null)), table3, "When ");
#line hidden
#line 27
 testRunner.And("I place order with new items and get calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("I calculate expected order price with additional items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.Then("I check calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Place, update and calculate order")]
        [NUnit.Framework.TestCaseAttribute("4", "4", "4", "Now", "3", "3", "3", null)]
        public virtual void PlaceUpdateAndCalculateOrder(string drinks, string starters, string mains, string time, string drinksUpdated, string startersUpdated, string mainsUpdated, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Drinks", drinks);
            argumentsOfScenario.Add("Starters", starters);
            argumentsOfScenario.Add("Mains", mains);
            argumentsOfScenario.Add("Time", time);
            argumentsOfScenario.Add("DrinksUpdated", drinksUpdated);
            argumentsOfScenario.Add("StartersUpdated", startersUpdated);
            argumentsOfScenario.Add("MainsUpdated", mainsUpdated);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Place, update and calculate order", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 34
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Drinks",
                            "Starters",
                            "Mains",
                            "Time"});
                table4.AddRow(new string[] {
                            string.Format("{0}", drinks),
                            string.Format("{0}", starters),
                            string.Format("{0}", mains),
                            string.Format("{0}", time)});
#line 35
 testRunner.Given("I store my order", ((string)(null)), table4, "Given ");
#line hidden
#line 38
 testRunner.And("I place order and get calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And("I calculate expected order price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And("I check calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Drinks",
                            "Starters",
                            "Mains",
                            "Time"});
                table5.AddRow(new string[] {
                            string.Format("{0}", drinksUpdated),
                            string.Format("{0}", startersUpdated),
                            string.Format("{0}", mainsUpdated),
                            string.Format("{0}", time)});
#line 41
 testRunner.When("I update current order", ((string)(null)), table5, "When ");
#line hidden
#line 44
 testRunner.And("I calculate expected order price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.Then("I check calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Place and calculate order (with constant expected result)")]
        [NUnit.Framework.TestCaseAttribute("4", "4", "4", "Now", "", null)]
        public virtual void PlaceAndCalculateOrderWithConstantExpectedResult(string drinks, string starters, string mains, string time, string totalPrice, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Drinks", drinks);
            argumentsOfScenario.Add("Starters", starters);
            argumentsOfScenario.Add("Mains", mains);
            argumentsOfScenario.Add("Time", time);
            argumentsOfScenario.Add("TotalPrice", totalPrice);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Place and calculate order (with constant expected result)", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 51
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Drinks",
                            "Starters",
                            "Mains",
                            "Time"});
                table6.AddRow(new string[] {
                            string.Format("{0}", drinks),
                            string.Format("{0}", starters),
                            string.Format("{0}", mains),
                            string.Format("{0}", time)});
#line 52
 testRunner.Given("I store my order", ((string)(null)), table6, "Given ");
#line hidden
#line 55
 testRunner.When("I place order and get calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.And("I calculate expected order price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.Then("I check calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Place, update and calculate order with time (with constant expected result)")]
        [NUnit.Framework.TestCaseAttribute("2", "1", "2", "18:00", "23.65", "2", "2", "20:00", "44.55", null)]
        public virtual void PlaceUpdateAndCalculateOrderWithTimeWithConstantExpectedResult(string drinksBefore, string startersBefore, string mainsBefore, string timeBefore, string totalPriceBefore, string drinksAfter, string mainsAfter, string timeAfter, string totalPriceAfter, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("DrinksBefore", drinksBefore);
            argumentsOfScenario.Add("StartersBefore", startersBefore);
            argumentsOfScenario.Add("MainsBefore", mainsBefore);
            argumentsOfScenario.Add("TimeBefore", timeBefore);
            argumentsOfScenario.Add("TotalPriceBefore", totalPriceBefore);
            argumentsOfScenario.Add("DrinksAfter", drinksAfter);
            argumentsOfScenario.Add("MainsAfter", mainsAfter);
            argumentsOfScenario.Add("TimeAfter", timeAfter);
            argumentsOfScenario.Add("TotalPriceAfter", totalPriceAfter);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Place, update and calculate order with time (with constant expected result)", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 62
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Drinks",
                            "Starters",
                            "Mains",
                            "Time"});
                table7.AddRow(new string[] {
                            string.Format("{0}", drinksBefore),
                            string.Format("{0}", startersBefore),
                            string.Format("{0}", mainsBefore),
                            string.Format("{0}", timeBefore)});
#line 63
 testRunner.Given("I store my order", ((string)(null)), table7, "Given ");
#line hidden
#line 66
 testRunner.And("I place order and get calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.And(string.Format("Total price with fees should be \'{0}\'", totalPriceBefore), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Drinks",
                            "Starters",
                            "Mains",
                            "Time"});
                table8.AddRow(new string[] {
                            string.Format("{0}", drinksAfter),
                            "<StartersAfter>",
                            string.Format("{0}", mainsAfter),
                            string.Format("{0}", timeAfter)});
#line 68
 testRunner.When("I add food to my order when drinks non discounted", ((string)(null)), table8, "When ");
#line hidden
#line 71
 testRunner.And("I place order with new items and get calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.Then(string.Format("Total price with fees should be \'{0}\'", totalPriceAfter), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Place, update and calculate order (with constant expected result)")]
        [NUnit.Framework.TestCaseAttribute("4", "4", "4", "Now", "3", "3", "3", "", "", null)]
        public virtual void PlaceUpdateAndCalculateOrderWithConstantExpectedResult(string drinks, string starters, string mains, string time, string drinksUpdated, string startersUpdated, string mainsUpdated, string totalPrice, string totalPriceWithUpdated, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Drinks", drinks);
            argumentsOfScenario.Add("Starters", starters);
            argumentsOfScenario.Add("Mains", mains);
            argumentsOfScenario.Add("Time", time);
            argumentsOfScenario.Add("DrinksUpdated", drinksUpdated);
            argumentsOfScenario.Add("StartersUpdated", startersUpdated);
            argumentsOfScenario.Add("MainsUpdated", mainsUpdated);
            argumentsOfScenario.Add("TotalPrice", totalPrice);
            argumentsOfScenario.Add("TotalPriceWithUpdated", totalPriceWithUpdated);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Place, update and calculate order (with constant expected result)", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 77
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Drinks",
                            "Starters",
                            "Mains",
                            "Time"});
                table9.AddRow(new string[] {
                            string.Format("{0}", drinks),
                            string.Format("{0}", starters),
                            string.Format("{0}", mains),
                            string.Format("{0}", time)});
#line 78
 testRunner.Given("I store my order", ((string)(null)), table9, "Given ");
#line hidden
#line 81
 testRunner.And("I place order and get calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
 testRunner.And("I calculate expected order price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
 testRunner.And("I check calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "Drinks",
                            "Starters",
                            "Mains",
                            "Time"});
                table10.AddRow(new string[] {
                            string.Format("{0}", drinksUpdated),
                            string.Format("{0}", startersUpdated),
                            string.Format("{0}", mainsUpdated),
                            string.Format("{0}", time)});
#line 84
 testRunner.When("I update current order", ((string)(null)), table10, "When ");
#line hidden
#line 87
 testRunner.And("I calculate expected order price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.Then("I check calculated total price with fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
