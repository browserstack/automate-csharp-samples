using NUnit.Framework;
using System;
using Selenium;
using System.Web;
using System.Text;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Test {
    [TestFixture]
    [Parallelizable]
    public class BrowserstackTest {
        private IWebDriver driver;

        [SetUp]
        public void Init() {
            DesiredCapabilities capability = DesiredCapabilities.Firefox();
            capability.SetCapability("browserstack.user", "USERNAME");
            capability.SetCapability("browserstack.key", "KEY");

            driver = new RemoteWebDriver(
                                         new Uri("http://hub.browserstack.com/wd/hub/"), capability);
        }

        [Test]
        public void TestCase() {
            driver.Navigate().GoToUrl("http://www.google.com");
            StringAssert.Contains("Google", driver.Title);
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("Browserstack");
            query.Submit();
        }

        [TearDown]
        public void Cleanup() {
            driver.Quit();
        }
    }
}
