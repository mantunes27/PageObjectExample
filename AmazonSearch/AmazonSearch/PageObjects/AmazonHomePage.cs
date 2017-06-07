using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AmazonSearch.PageObjects
{
    public class AmazonHomePage
    {
        private readonly IWebDriver _driver;

        
        public AmazonHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public const string url = "https://www.amazon.co.uk/";
        public const string SearchBar = "/html/body/div[1]/header/div/div[1]/div[3]/div/form/div[3]/div[1]/input";
        public const string SearchButton = "/html/body/div[1]/header/div/div[1]/div[3]/div/form/div[2]/div/input";
        public const string product = "game of thrones a song of ice and fire";
            
        //Navigate to Amazon
        public static AmazonHomePage goToAmazonHomePage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(url);
            return new AmazonHomePage(driver);
        }

        //Type Game of thrones in the search function
        public static AmazonHomePage TypeSearchBar(IWebDriver driver)
        {
            driver.FindElement(By.XPath(SearchBar)).SendKeys(product);
            return new AmazonHomePage(driver);
        }

        //Click the search button
        public static AmazonHomePage ClickSearch(IWebDriver driver)
        {
            driver.FindElement(By.XPath(SearchButton)).Click();
            return new AmazonHomePage(driver);
        }

    }
}
