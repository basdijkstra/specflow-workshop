using NUnit.Framework;
using SpecFlowWorkshop.Models;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowWorkshop.StepDefinitions
{
    [Binding]
    public class UsingScenarioOutlineStepDefinitions
    {
        private Calculator calculator;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            calculator = new Calculator();
        }

        [Given(@"the calculator shows (.*) in its display")]
        public void GivenTheCalculatorShowsInItsDisplay(int NumberToDisplay)
        {
            calculator.SetTotalTo(NumberToDisplay);
        }

        [When(@"I add (\d+)")]
        public void WhenIAdd(int NumberToAdd)
        {
            calculator.Add(NumberToAdd);
        }

        [When(@"I multiply with (.*)")]
        public void WhenIMultiplyWith(int NumberToMultiplyWith)
        {
            calculator.Multiply(NumberToMultiplyWith);
        }

        [When(@"I subtract (.*)")]
        public void WhenISubtract(int NumberToSubtract)
        {
            calculator.Subtract(NumberToSubtract);
        }

        [Then(@"the calculator shows (.*) in its display")]
        public void ThenTheCalculatorShowsInItsDisplay(int ExpectedNumberInDisplay)
        {
            Assert.That(calculator.CurrentTotal, Is.EqualTo(ExpectedNumberInDisplay));
        }
    }
}
