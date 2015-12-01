using System;
using System.Collections.Generic;
using System.Text;
using Gallio.Framework;
using MbUnit.Framework;
using MbUnit.Framework.ContractVerifiers;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace GalioTest
{
    [TestFixture]
    public class TestFixture1
    {
        private IWebDriver driver;

        [SetUp]
        public void Init()
        {
            DesiredCapabilities capability = DesiredCapabilities.Chrome();  
            capability.SetCapability("browserstack.user", "<USERNAME>");
            capability.SetCapability("browserstack.key", "<KEY>");

            driver = new RemoteWebDriver(
              new Uri("http://hub.browserstack.com/wd/hub/"), capability
            );
        }
        [Test]
        public void Test()
        {
            driver.Navigate().GoToUrl("http://www.yahoo.com");
            //StringAssert.Contains("Google", driver.Title);
            //IWebElement query = driver.FindElement(By.Name("q"));
            //query.SendKeys("Browserstack");
            //query.Submit();
            Console.WriteLine("Test3");
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
