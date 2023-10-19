using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace TvHut.StepDefinitions
{
    [Binding]
    public class SearchBar
    {
        private IWebDriver driver;
        private IWebElement searchBar;

        public SearchBar()
        {
            driver = new ChromeDriver();
        }
        [When(@"I am on the main page")]
        public void WhenIAmOnTheMainPage()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
        }

        [When(@"I search for the search bar")]
        public void WhenISearchForTheSearchBar()
        {
            searchBar = driver.FindElement(By.XPath("//input[@placeholder='Search...']"));

        }

        [Then(@"I should see search bar")]
        public void ThenIShouldSeeSearchBar()
        {
            Assert.IsNotNull(searchBar, "Search bar not found");          
            driver.Quit();
        }
    }
}
