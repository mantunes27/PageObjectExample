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
    public class ItemPage
    {
        private readonly IWebDriver _driver;

        public ItemPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public const string FirstPrice = "/html/body/div[1]/div[2]/div/div[3]/div[2]/div/div[4]/div[1]/div/ul/li[1]/div/div/div/div[2]/div[2]/div[1]/div[2]/a/span[2]";
        public const string RightPrice = "£7.99";

        public static ItemPage CheckPrice(IWebDriver driver)
        {
           
            IWebElement element = driver.FindElement(By.XPath(FirstPrice));
            string price = element.GetAttribute("innerHTML");
            if(price == RightPrice)
            {
                Console.WriteLine("Test Passed");
                return new ItemPage(driver);
            }
            else
            {
                throw new Exception();
            }
            
        }
    }
}
