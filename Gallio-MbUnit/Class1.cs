
using MbUnit.Framework;
using System;
using System.Web;
using System.Text;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace GalioTest {
  [TestFixture]
  public class Class1 {
    private IWebDriver driver;

    [SetUp]
    public void Init() {
      DesiredCapabilities capability = DesiredCapabilities.Firefox();
      capability.SetCapability("browserstack.user", "<USERNAME>");
      capability.SetCapability("browserstack.key", "<KEY>");

      driver = new RemoteWebDriver(
        new Uri("http://hub.browserstack.com/wd/hub/"), capability
      );
    }

    [Test]
    public void TestCase() {
      driver.Navigate().GoToUrl("http://www.google.com");
      //StringAssert.Contains("Google", driver.Title);
      IWebElement query = driver.FindElement(By.Name("q"));
      query.SendKeys("Browserstack");
      query.Submit();
      Console.WriteLine("Test1");
    }

    [Test]
    public void TestCase2()
    {
        driver.Navigate().GoToUrl("http://www.google.com");
        //StringAssert.Contains("Google", driver.Title);
        IWebElement query = driver.FindElement(By.Name("q"));
        query.SendKeys("Browserstack");
        query.Submit();
        Console.WriteLine("Test2");
    }

    [TearDown]
    public void Cleanup() {
      driver.Quit();
    }
  }
}