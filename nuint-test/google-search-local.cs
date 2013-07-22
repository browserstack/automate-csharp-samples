using NUnit.Framework;
using System;
using Selenium;
using System.Web;
using System.Text;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Test {
    [TestFixture()]
    public class BrowserstackTest {
        private IWebDriver driver;

        [SetUp]
        public void Init() {
            driver = new FirefoxDriver();
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
