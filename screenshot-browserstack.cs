using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Automate
{
  public class ScreenShotRemoteWebDriver : RemoteWebDriver, ITakesScreenshot
  {
    public ScreenShotRemoteWebDriver(Uri uri, DesiredCapabilities dc) : base(uri, dc)
    {
    }
    public Screenshot GetScreenshot()
    {
      // Get the screenshot as base64.
      Response screenshotResponse = this.Execute(DriverCommand.Screenshot, null);
      string base64 = screenshotResponse.Value.ToString();

      // ... and convert it.
      return new Screenshot(base64);
    }
  }

  [TestClass]
  public class BrowserStackTest{
    ScreenShotRemoteWebDriver driver;

    [TestInitialize]
    public void Setup(){
      DesiredCapabilities caps = new DesiredCapabilities();
      caps.SetCapability("browser", "IE");
      caps.SetCapability("browser_version", "9.0");
      caps.SetCapability("os", "Windows");
      caps.SetCapability("os_version", "7");
      caps.SetCapability("build", "screenshot test");
      caps.SetCapability("browserstack.debug", "true");
      caps.SetCapability("browserstack.user", );
      caps.SetCapability("browserstack.key", );
      driver = new ScreenShotRemoteWebDriver(new Uri("http://hub.browserstack.com/wd/hub/"), caps);
    }

    [TestMethod]
    public void ScreenshotTest()
    {
      driver.Navigate().GoToUrl("http://www.google.com");
      Console.Out.WriteLine("Title: " + driver.Title);

      IWebElement element = driver.FindElement(By.Name("q"));
      element.SendKeys("Browserstack");
      element.Submit();
      driver.GetScreenshot();
    }

    [TestCleanup]
    public void TearDown(){
      driver.Quit();
    }
  }
}
