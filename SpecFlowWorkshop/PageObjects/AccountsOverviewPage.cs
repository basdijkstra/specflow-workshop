using OpenQA.Selenium;

namespace SpecFlowWorkshop.PageObjects
{
    public class AccountsOverviewPage : BasePage
    {
        private IWebDriver driver;

        public AccountsOverviewPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
    }
}
