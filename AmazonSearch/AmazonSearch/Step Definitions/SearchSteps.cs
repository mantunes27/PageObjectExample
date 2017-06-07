using AmazonSearch.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AmazonSearch.Step_Definitions
{
    [Binding]
    public class SearchSteps
    {
        //public AmazonHomePage AmazonHomePage;

        IWebDriver driver = new ChromeDriver();
        [Given(@"I have navigated to Amazon")]
        public void GivenIHaveNavigatedToAmazon()
        {
            AmazonHomePage.goToAmazonHomePage(driver);
        }
        
        [Given(@"I typed game of thrones a song of ice and fire")]
        public void GivenITypedGameOfThronesASongOfIceAndFire()
        {
           AmazonHomePage.TypeSearchBar(driver);
        }
        
        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
            AmazonHomePage.ClickSearch(driver);
        }
        
        [Then(@"the price of the book should be £(.*)")]
        public void ThenThePriceOfTheBookShouldBe(Decimal p0)
        {
           ItemPage.CheckPrice(driver);
        }
    }
}
