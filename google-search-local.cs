using System;
using Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest {
    class Program {
        static void Main(string[] args) {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine(driver.Title);

            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("Browserstack");
            query.Submit();
            Console.WriteLine(driver.Title);
            driver.Quit();
        }
    }
}
