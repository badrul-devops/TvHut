using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace TvHut.StepDefinitions
{
    [Binding]
    public class WebTitle
    {
        private IWebDriver driver;
        private string pageTitle;

        public WebTitle()
        {
            driver = new ChromeDriver();
        }

        [Given(@"I am on the main page")]
        public void GivenIAmOnTheMainPage()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
        }

        [Then(@"verify if the page title should be as it is or not")]
        public void ThenVerifyIfThePageTitleShouldBeAsItIsOrNot()
        {
            pageTitle = driver.Title;
            Assert.IsNotNull(pageTitle, "Page title is null");
            Assert.IsFalse(string.IsNullOrWhiteSpace(pageTitle), "Page title is empty or whitespace");

            if (!string.IsNullOrWhiteSpace(pageTitle))
            {
                Console.WriteLine($"Page Title: {pageTitle}");
            }

            driver.Quit();
        }
    }
}