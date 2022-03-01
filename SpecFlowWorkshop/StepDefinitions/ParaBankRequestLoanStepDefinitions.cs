using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowWorkshop.Models;
using SpecFlowWorkshop.PageObjects;
using TechTalk.SpecFlow.Assist;

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
                .LoginAs("john", "demo")
                .SelectMenuItem("Request Loan");
        }

        [When(@"he submits the following loan request")]
        public void WhenHeSubmitsTheFollowingLoanRequest(Table table)
        {
            LoanRequest loanRequest = table.CreateInstance<LoanRequest>();

            new RequestLoanPage(driver)
                .SubmitLoanRequest(
                    loanRequest.LoanAmount,
                    loanRequest.DownPayment,
                    loanRequest.FromAccountId
                );
        }

        [Then(@"the loan application is approved")]
        public void ThenTheLoanApplicationIsApproved()
        {
            Assert.That(
                new RequestLoanResultPage(driver).GetLoanApplicationResult(),
                Is.EqualTo("Approved")
            );
        }

        [Then(@"the loan application is denied")]
        public void ThenTheLoanApplicationIsDenied()
        {
            Assert.That(
                new RequestLoanResultPage(driver).GetLoanApplicationResult(),
                Is.EqualTo("Denied")
            );
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
