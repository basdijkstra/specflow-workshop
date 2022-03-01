using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowWorkshop.PageObjects;

namespace SpecFlowWorkshop.StepDefinitions
{
    [Binding]
    public class ParaBankRequestLoanStepDefinitions
    {
        private IWebDriver driver;

        [BeforeScenario]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Given(@"John wants to apply for a loan")]
        public void GivenJohnWantsToApplyForALoan()
        {
            new LoginPage(driver)
                .LoginAs("john", "demo");
        }

        [When(@"he submits the following loan request")]
        public void WhenHeSubmitsTheFollowingLoanRequest(Table table)
        {
        }

        [Then(@"the loan application is approved")]
        public void ThenTheLoanApplicationIsApproved()
        {
        }

        [Then(@"the loan application is denied")]
        public void ThenTheLoanApplicationIsDenied()
        {
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
