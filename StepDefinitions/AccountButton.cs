using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace TvHut.StepDefinitions
{
    [Binding]
    public class AccountButton
    {
        private IWebDriver driver;

        public AccountButton()
        {
            driver = new ChromeDriver();
        }

        [Given(@"I go on the main page")]
        public void GivenIGoOnTheMainPage()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
        }

        [Then(@"I should see an Account button")]
        public void ThenIShouldSeeAnAccountButton()
        {
            // Use explicit wait to wait for 10 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            bool isAccountButtonAvailable = wait.Until(driver =>
            {
                return IsElementAvailable(driver, By.XPath("//li[@class='menu-item top-menu-item top-menu-item-10']//a[@href='javascript:open_login_popup()']"));
            });

            Assert.IsTrue(isAccountButtonAvailable, "Account button is not available on the page");

            driver.Quit();
        }

        private bool IsElementAvailable(IWebDriver driver, By by)
        {
            try
            {
                var element = driver.FindElement(by);
                return element != null;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
