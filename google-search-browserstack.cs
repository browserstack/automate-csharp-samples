using System;
using Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SeleniumTest {
    class Program {
        static void Main(string[] args) {
            IWebDriver driver;
            DesiredCapabilities capability = DesiredCapabilities.Firefox();
            capability.SetCapability("browserstack.user", "USERNAME");
            capability.SetCapability("browserstack.key", "KEY");

            driver = new RemoteWebDriver(
                                         new Uri("http://hub.browserstack.com/wd/hub/"), capability);
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
