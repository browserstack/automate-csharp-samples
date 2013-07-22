using MbUnit.Framework;
using NHamcrest;
using System;
using Selenium;
using System.Web;
using System.Text;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Automate {
    [TestFixture]
    [Parallelizable]
    public class FFTest {
        private IWebDriver driver;

        [SetUp]
        public void Init() {
            driver = new FirefoxDriver();
        }

        [Test]
        public void TestCase() {
            driver.Navigate().GoToUrl("http://www.google.com");
            Assert.AreEqual("Google", driver.Title);
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
