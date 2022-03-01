using OpenQA.Selenium;

namespace SpecFlowWorkshop.PageObjects
{
    public class RequestLoanResultPage : BasePage
    {
        private IWebDriver driver;

        private By textfieldLoanApplicationResult = By.Id("loanStatus");

        public RequestLoanResultPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public string GetLoanApplicationResult()
        {
            return GetElementText(textfieldLoanApplicationResult);
        }
    }
}
