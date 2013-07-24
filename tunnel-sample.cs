using System;
using Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SeleniumTest {
    class Program {
        static void Main(string[] args) {
            DesiredCapabilities capability = DesiredCapabilities.Firefox();
            capability.SetCapability("browserstack.user", "USERNAME");
            capability.SetCapability("browserstack.key", "KEY");

            // Need to pass for tunnel setup
            capability.SetCapability("browserstack.tunnel", "true");

            IWebDriver driver = new RemoteWebDriver(new Uri("http://hub.browserstack.com/wd/hub/"), capability);
            
            // Navigate to your local URL
            driver.Navigate().GoToUrl("http://localhost:8080/");
            Console.WriteLine(driver.Title);

            driver.Quit();
        }
    }
}
