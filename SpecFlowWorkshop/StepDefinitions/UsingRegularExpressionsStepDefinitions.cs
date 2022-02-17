using System;
using TechTalk.SpecFlow;

namespace SpecFlowWorkshop.StepDefinitions
{
    [Binding]
    public class UsingRegularExpressionsStepDefinitions
    {
        [Given(@"I have an empty basket")]
        public void GivenIHaveAnEmptyBasket()
        {
        }

        [Given(@"I am a collector of flags")]
        public void GivenIAmACollectorOfFlags()
        {
        }

        [Given(@"I have an empty fruit bowl")]
        public void GivenIHaveAnEmptyFruitBowl()
        {
        }

        [When(@"I put (.*) apples in my basket")]
        public void WhenIPutApplesInMyBasket(int numberOfApples)
        {
        }

        [When(@"I create a collection of flags from the Benelux countries")]
        public void WhenICreateACollectionOfFlagsFromTheBeneluxCountries()
        {
        }

        [When(@"I throw in an apple")]
        public void WhenIThrowInAnApple()
        {
        }

        [When(@"I throw in a banana")]
        public void WhenIThrowInABanana()
        {
        }

        [When(@"I throw in a pear")]
        public void WhenIThrowInAPear()
        {
        }

        [Then(@"I should add a flag from The Netherlands")]
        public void ThenIShouldAddAFlagFromTheNetherlands()
        {
        }

        [Then(@"I should add a flag from Belgium")]
        public void ThenIShouldAddAFlagFromBelgium()
        {
        }

        [Then(@"I should add a flag from Luxembourg")]
        public void ThenIShouldAddAFlagFromLuxembourg()
        {
        }

        [Then(@"I have (.*) apples in my basket")]
        public void ThenIHaveApplesInMyBasket(int numberOfApples)
        {
        }

        [Then(@"I have a filled fruit bowl")]
        public void ThenIHaveAFilledFruitBowl()
        {
        }
    }
}
