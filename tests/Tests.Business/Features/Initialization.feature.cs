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
namespace Tests.Business.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "Environment(development)")]
    [Xunit.TraitAttribute("Category", "RestoreDatabase")]
    public partial class InitializationFeature : object, Xunit.IClassFixture<InitializationFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "Environment(development)",
                "RestoreDatabase"};
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
        public InitializationFeature(InitializationFeature.FixtureData fixtureData, Tests_Business_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en"), "Features", "Initialization", "Initalizing the application", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Initial Scenario")]
        [Xunit.TraitAttribute("FeatureTitle", "Initialization")]
        [Xunit.TraitAttribute("Description", "Initial Scenario")]
        [Xunit.TraitAttribute("Category", "TestCase(0)")]
        public void InitialScenario()
        {
            string[] tagsOfScenario = new string[] {
                    "TestCase(0)"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Initial Scenario", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                testRunner.Given("I have a valid configuration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
                testRunner.When("I initialize the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                testRunner.Then("I should get a valid run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Not implemented scenario")]
        [Xunit.TraitAttribute("FeatureTitle", "Initialization")]
        [Xunit.TraitAttribute("Description", "Not implemented scenario")]
        [Xunit.TraitAttribute("Category", "NotYetImplemented")]
        public void NotImplementedScenario()
        {
            string[] tagsOfScenario = new string[] {
                    "NotYetImplemented"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Not implemented scenario", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                testRunner.Given("I have a valid configuration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
                testRunner.When("I initialize the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                testRunner.Then("I should get a valid run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                InitializationFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                InitializationFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion